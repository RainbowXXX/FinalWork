using Dapper;
using FinalWork.Configs;
using FinalWork.Entities;
using FinalWork.Tools;
using MySql.Data.MySqlClient;
using System.Data;

namespace FinalWork.UIForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            if (SqlHandler.Instance.conn.Query<UserLoginEntity>("SELECT * FROM user_login").ToList().Count == 0)
            {
                new NewUse().ShowDialog();
            }
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            var user = UserTools.validate_user(textBox_username_input.Text, textBox_passwd_input.Text);
            if(user == null)
            {
                login_failed();
                return;
            }

            GlobalTools.cur_uid = user.Id;
            // 验证通过
            switch (user.Privilege)
            {
                case UserLoginEntity.PrivilegeLevel.SYSADMIN_LEVEL:
                    this.Hide();
                    new SysAdmin().ShowDialog();
                    this.Show();
                    break;
                case UserLoginEntity.PrivilegeLevel.ADMIN_LEVEL:
                    this.Hide();
                    new BookInfo().ShowDialog();
                    this.Show();
                    break;
                case UserLoginEntity.PrivilegeLevel.USER_LEVEL:
                    this.Hide();
                    new BorrowReturnForm().ShowDialog();
                    this.Show();
                    break;

                default:
                    break;
            }

            textBox_passwd_input.Text = string.Empty;
        }

        private DialogResult login_failed(string reason= "用户名或密码错误")
        {
            return MessageBox.Show(reason, "登录失败.", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
        }
    }
}