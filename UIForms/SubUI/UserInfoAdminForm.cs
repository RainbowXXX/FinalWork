using Dapper;
using FinalWork.Configs;
using FinalWork.Entities;
using FinalWork.Tools;
using FinalWork.UIForms.SubUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalWork.UIForms
{
    public partial class UserInfoAdminForm : Form
    {
        private List<UserLoginEntity> userLoginEntities;

        public UserInfoAdminForm()
        {
            InitializeComponent();
            clearDetail();
            refresh_content();
        }

        public void refresh_content()
        {
            userLoginEntities = SqlHandler.Instance.conn.Query<UserLoginEntity>("SELECT * FROM user_login;").ToList();
            listView_users.Items.Clear();
            foreach (var user_login in userLoginEntities)
            {
                ListViewItem item = new ListViewItem(user_login.UserName);
                item.SubItems.Add(user_login.Privilege.ToString());
                // 只有读者有可选信息
                if (user_login.Privilege == UserLoginEntity.PrivilegeLevel.USER_LEVEL)
                {
                    UserOptionalInfoEntity? userOptionalInfo = UserTools.GetUserOptionalInfo(user_login.Id, true);

                    item.SubItems.Add(userOptionalInfo?.name);
                    item.SubItems.Add(userOptionalInfo?.gender);
                    item.SubItems.Add(userOptionalInfo?.age?.ToString());
                    item.SubItems.Add(userOptionalInfo?.email);
                    item.SubItems.Add(userOptionalInfo?.profession);
                    item.SubItems.Add(userOptionalInfo?.hobby);
                }

                listView_users.Items.Add(item);
            }

            foreach (ColumnHeader column in listView_users.Columns)
            {
                column.Width = -2;
            }
        }

        private void clearDetail()
        {
            this.textBox_username_input.Enabled = true;
            this.comboBox_privilege_input.Enabled = true;

            this.comboBox_gender_input.Enabled = true;
            this.textBox_age_input.Enabled = true;
            this.textBox_email_input.Enabled = true;
            this.textBox_hobby_input.Enabled = true;
            this.textBox_name_input.Enabled = true;
            this.textBox_profession_input.Enabled = true;

            this.textBox_username_input.Text = string.Empty;
            this.comboBox_privilege_input.SelectedIndex = -1;

            this.comboBox_gender_input.SelectedIndex = -1;
            this.textBox_age_input.Text = string.Empty;
            this.textBox_email_input.Text = string.Empty;
            this.textBox_hobby_input.Text = string.Empty;
            this.textBox_name_input.Text = string.Empty;
            this.textBox_profession_input.Text = string.Empty;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            panel_optional.Visible = true;
            refresh_content();
            ShowDetail();
        }

        private void ShowDetail()
        {
            var selectedItems = listView_users.SelectedItems;
            if (selectedItems.Count <= 0)
            {
                clearDetail();
                return;
            }

            var selectedSubItems = selectedItems[0].SubItems;

            this.textBox_username_input.Text = selectedSubItems[0].Text;
            this.textBox_username_input.Enabled = false;
            this.comboBox_privilege_input.Text = selectedSubItems[1].Text;
            this.comboBox_privilege_input.Enabled = true;

            if (!this.panel_optional.Visible) return;

            if (selectedSubItems.Count <= 3 || selectedSubItems[3] == null) this.comboBox_gender_input.SelectedIndex = 2;
            else this.comboBox_gender_input.SelectedIndex = selectedSubItems[3].Text == "男" ? 0 : selectedSubItems[3].Text == "女" ? 1 : 2;
            this.textBox_age_input.Text = selectedSubItems.Count > 4 ? selectedSubItems[4].Text : string.Empty;
            this.textBox_email_input.Text = selectedSubItems.Count > 5 ? selectedSubItems[5].Text : string.Empty;
            this.textBox_hobby_input.Text = selectedSubItems.Count > 7 ? selectedSubItems[7].Text : string.Empty;
            this.textBox_name_input.Text = selectedSubItems.Count > 2 ? selectedSubItems[2].Text : string.Empty;
            this.textBox_profession_input.Text = selectedSubItems.Count > 6 ? selectedSubItems[6].Text : string.Empty;
        }

        private void listView_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            var selectedItems = listView_users.SelectedItems;
            if (selectedItems.Count <= 0)
            {
                clearDetail();
                return;
            }

            var selectedSubItems = selectedItems[0].SubItems;
            UserLoginEntity.PrivilegeLevel privilege = (UserLoginEntity.PrivilegeLevel)Enum.Parse(typeof(UserLoginEntity.PrivilegeLevel), selectedSubItems[1].Text);
            if (privilege > GlobalTools.user_level)
            {
                register_failed("权限不足");
                return;
            }

            var optional_params = new { UserName = textBox_username_input.Text, Privilege = (int)(UserLoginEntity.PrivilegeLevel)Enum.Parse(typeof(UserLoginEntity.PrivilegeLevel), comboBox_privilege_input.Text) };
            SqlHandler.Instance.conn.Execute("UPDATE user_login SET privilege = @Privilege WHERE user_name = @UserName", optional_params);
            if (this.panel_optional.Visible)
            {
                var optional_param = new { Name = textBox_name_input.Text, Gender = comboBox_gender_input.Text, Age = textBox_age_input.Text, Email = textBox_email_input.Text, Profession = textBox_profession_input.Text, Hobby = textBox_hobby_input.Text };
                SqlHandler.Instance.conn.Execute("UPDATE user SET gender = @Gender, age = @Age, email = @Email, profession = @Profession, hobby = @Hobby WHERE name = @Name", optional_param);
            }
            refresh_content();
        }

        private void comboBox_privilege_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_privilege_input.SelectedIndex < 0) return;
            this.panel_optional.Visible = this.comboBox_privilege_input.SelectedIndex == 0;
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.textBox_username_input.Text == "")
            {
                MessageBox.Show("请选择用户再修改密码.", "请选择用户", MessageBoxButtons.OK);
                return;
            }
            new PasswdChangeForm(this.textBox_username_input.Text).ShowDialog();
            return;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            UserOptionalInfoEntity userOptionalInfoEntity = null;
            UserLoginEntity.PrivilegeLevel privilege = (UserLoginEntity.PrivilegeLevel)Enum.Parse(typeof(UserLoginEntity.PrivilegeLevel), comboBox_privilege_input.Text);
            if(privilege > GlobalTools.user_level)
            {
                register_failed("权限不足");
                return;
            }
            if (panel_optional.Visible) userOptionalInfoEntity = new UserOptionalInfoEntity(0, textBox_name_input.Text, comboBox_gender_input.Text, textBox_age_input.Text == "" ? null : int.Parse(textBox_age_input.Text), textBox_email_input.Text, textBox_profession_input.Text, textBox_hobby_input.Text);
            var ret = UserTools.CreateUser(textBox_username_input.Text, privilege, userOptionalInfoEntity);
            UserTools.ChangePasswd(textBox_username_input.Text, "passwd");
            if (ret != null) { refresh_content(); refresh_content(); return; }
            register_failed();
        }

        private DialogResult register_failed(string reason = "用户名重复")
        {
            return MessageBox.Show(reason, "操作失败.", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username_to_del = textBox_username_input.Text;
            int privilege = comboBox_privilege_input.SelectedIndex;
            if(privilege >= (int)GlobalTools.user_level) {
                MessageBox.Show("没有权限", "删除确认", MessageBoxButtons.OK);
                return;
            }
            if(username_to_del == "")
            {
                MessageBox.Show("请选择用户", "删除确认", MessageBoxButtons.OK);
                return;
            }
            var ret = MessageBox.Show("是否删除 " + username_to_del + " 用户?", "删除确认", MessageBoxButtons.OKCancel);
            if (ret != DialogResult.OK) return;
            UserTools.RemoveUser(username_to_del);
            refresh_content();
            return;
        }
    }
}
