using Dapper;
using FinalWork.Configs;
using FinalWork.Entities;
using FinalWork.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWork.UIForms
{
    public partial class PasswdChange : Form
    {
        public PasswdChange(string username)
        {
            InitializeComponent();
            this.textBox_username_input.Text = username;
            this.textBox_username_input.Enabled = false;
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            var user = UserTools.validate_user(textBox_username_input.Text, textBox_old_passwd_input.Text);
            if (user == null)
            {
                change_failed();
                return;
            }
            if (textBox_old_passwd_input.Text == textBox_new_passwd_input.Text)
            {
                change_failed("旧密码不能与新密码相同.");
                return;
            }
            if (textBox_new_passwd_input.Text != textBox_confirm_password_input.Text)
            {
                change_failed("两次密码输入不同.");
                return;
            }
            UserTools.ChangePasswd(textBox_username_input.Text, textBox_new_passwd_input.Text);
            this.Close();
            return;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private DialogResult change_failed(string reason = "用户名或密码错误")
        {
            return MessageBox.Show(reason, "修改失败.", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
        }
    }
}
