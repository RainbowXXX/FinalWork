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

namespace FinalWork.UIForms.SubUI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (textBox_password_input.Text.ToString() != textBox_password_input.Text.ToString())
            {
                Retry("两次密码输入不同");
                return;
            }
            UserOptionalInfoEntity userOptionalInfo = new UserOptionalInfoEntity(0, null, null, null, null, null, null);
            if(UserTools.CreateUser(textBox_username_input.Text, UserLoginEntity.PrivilegeLevel.USER_LEVEL, userOptionalInfo) is not null)
            {
                UserTools.ChangePasswd(textBox_username_input.Text, textBox_password_input.Text);
                Success();
                this.Close();
                return;
            }

            Retry("注册失败, 请重试");
            return;
        }

        private DialogResult Retry(string reason)
        {
            return MessageBox.Show(reason, "注册失败", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
        }

        private DialogResult Success(string reason = "")
        {
            return DialogResult.None;
        }

        private void label_username_hint_Click(object sender, EventArgs e)
        {

        }
    }
}
