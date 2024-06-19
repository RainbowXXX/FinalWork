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
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
            UserLoginEntity user = UserTools.GetUserInfo(GlobalTools.cur_uid);
            textBox_username_input.Text = user.UserName;
            comboBox_privilege_input.Text = user.Privilege.ToString();
            if (user.Privilege <= UserLoginEntity.PrivilegeLevel.USER_LEVEL)
            {
                UserOptionalInfoEntity userOptionalInfo = UserTools.GetUserOptionalInfo(GlobalTools.cur_uid, false);

                if (userOptionalInfo != null) {
                    textBox_name_input.Text = userOptionalInfo.name ?? string.Empty;
                    comboBox_gender_input.Text = userOptionalInfo.gender ?? string.Empty;
                    textBox_age_input.Text = userOptionalInfo.age?.ToString() ?? string.Empty;
                    textBox_email_input.Text = userOptionalInfo.email ?? string.Empty;
                    textBox_profession_input.Text = userOptionalInfo.profession ?? string.Empty;
                    textBox_hobby_input.Text = userOptionalInfo.hobby ?? string.Empty;
                }
                else
                {
                    textBox_name_input.Text         =       string.Empty;
                    comboBox_gender_input.Text      =       string.Empty;
                    textBox_age_input.Text          =       string.Empty;
                    textBox_email_input.Text        =       string.Empty;
                    textBox_profession_input.Text   =       string.Empty;
                    textBox_hobby_input.Text        =       string.Empty;
                }
            }

            textBox_username_input.Enabled = false;
            comboBox_privilege_input.Enabled = false;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserOptionalInfoEntity user = new UserOptionalInfoEntity(GlobalTools.cur_uid, textBox_name_input.Text, comboBox_gender_input.Text, int.Parse(textBox_age_input.Text), textBox_email_input.Text, textBox_profession_input.Text, textBox_hobby_input.Text);
            UserTools.SetUserOptionalInfo(GlobalTools.cur_uid, user);
            this.Close();
        }
    }
}
