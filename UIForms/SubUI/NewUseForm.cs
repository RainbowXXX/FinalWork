using Dapper;
using FinalWork.Configs;
using FinalWork.Entities;
using FinalWork.Tools;
using MySql.Data.MySqlClient;
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
    public partial class NewUseForm : Form
    {
        public NewUseForm()
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
            string salt = UUIDTool.GetUUID();
            string hash = Sha256Tool.Calc(textBox_password_input.Text.ToString() + salt);
            var optionalParams = new { Privilege = UserLoginEntity.PrivilegeLevel.SYSADMIN_LEVEL, UserName = textBox_username_input.Text.ToString(), PasswdSalt = salt, PasswdHash = hash };
            var num_row_affected = SqlHandler.Instance.conn.Execute("INSERT INTO work_database.user_login (privilege, user_name, password_hash, password_salt) VALUES (@Privilege, @UserName, @PasswdHash, @PasswdSalt);", optionalParams);

            if (num_row_affected > 0)
            {
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
