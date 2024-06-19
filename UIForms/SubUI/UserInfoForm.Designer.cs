namespace FinalWork.UIForms
{
    partial class UserInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoForm));
            panel_optional = new Panel();
            textBox_hobby_input = new TextBox();
            textBox_profession_input = new TextBox();
            textBox_email_input = new TextBox();
            comboBox_gender_input = new ComboBox();
            textBox_age_input = new TextBox();
            textBox_name_input = new TextBox();
            label_hobby = new Label();
            label_profession = new Label();
            label_email = new Label();
            label_age = new Label();
            label_gender = new Label();
            label_name = new Label();
            comboBox_privilege_input = new ComboBox();
            textBox_username_input = new TextBox();
            label_privilege_input = new Label();
            label_username_hint = new Label();
            button_cancel = new Button();
            button1 = new Button();
            panel_optional.SuspendLayout();
            SuspendLayout();
            // 
            // panel_optional
            // 
            panel_optional.BackColor = Color.Transparent;
            panel_optional.Controls.Add(textBox_hobby_input);
            panel_optional.Controls.Add(textBox_profession_input);
            panel_optional.Controls.Add(textBox_email_input);
            panel_optional.Controls.Add(comboBox_gender_input);
            panel_optional.Controls.Add(textBox_age_input);
            panel_optional.Controls.Add(textBox_name_input);
            panel_optional.Controls.Add(label_hobby);
            panel_optional.Controls.Add(label_profession);
            panel_optional.Controls.Add(label_email);
            panel_optional.Controls.Add(label_age);
            panel_optional.Controls.Add(label_gender);
            panel_optional.Controls.Add(label_name);
            panel_optional.Location = new Point(271, 145);
            panel_optional.Name = "panel_optional";
            panel_optional.Size = new Size(317, 200);
            panel_optional.TabIndex = 9;
            // 
            // textBox_hobby_input
            // 
            textBox_hobby_input.Location = new Point(60, 171);
            textBox_hobby_input.Name = "textBox_hobby_input";
            textBox_hobby_input.Size = new Size(121, 23);
            textBox_hobby_input.TabIndex = 9;
            // 
            // textBox_profession_input
            // 
            textBox_profession_input.Location = new Point(60, 139);
            textBox_profession_input.Name = "textBox_profession_input";
            textBox_profession_input.Size = new Size(121, 23);
            textBox_profession_input.TabIndex = 8;
            // 
            // textBox_email_input
            // 
            textBox_email_input.Location = new Point(60, 108);
            textBox_email_input.Name = "textBox_email_input";
            textBox_email_input.Size = new Size(121, 23);
            textBox_email_input.TabIndex = 7;
            // 
            // comboBox_gender_input
            // 
            comboBox_gender_input.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_gender_input.FormattingEnabled = true;
            comboBox_gender_input.Items.AddRange(new object[] { "男", "女", "未知" });
            comboBox_gender_input.Location = new Point(60, 45);
            comboBox_gender_input.Name = "comboBox_gender_input";
            comboBox_gender_input.Size = new Size(121, 25);
            comboBox_gender_input.TabIndex = 5;
            // 
            // textBox_age_input
            // 
            textBox_age_input.Location = new Point(60, 76);
            textBox_age_input.Name = "textBox_age_input";
            textBox_age_input.Size = new Size(121, 23);
            textBox_age_input.TabIndex = 6;
            // 
            // textBox_name_input
            // 
            textBox_name_input.Location = new Point(60, 14);
            textBox_name_input.Name = "textBox_name_input";
            textBox_name_input.Size = new Size(121, 23);
            textBox_name_input.TabIndex = 5;
            // 
            // label_hobby
            // 
            label_hobby.AutoSize = true;
            label_hobby.Location = new Point(6, 174);
            label_hobby.Name = "label_hobby";
            label_hobby.Size = new Size(32, 17);
            label_hobby.TabIndex = 5;
            label_hobby.Text = "爱好";
            // 
            // label_profession
            // 
            label_profession.AutoSize = true;
            label_profession.Location = new Point(6, 142);
            label_profession.Name = "label_profession";
            label_profession.Size = new Size(32, 17);
            label_profession.TabIndex = 4;
            label_profession.Text = "职业";
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(6, 111);
            label_email.Name = "label_email";
            label_email.Size = new Size(32, 17);
            label_email.TabIndex = 3;
            label_email.Text = "邮件";
            // 
            // label_age
            // 
            label_age.AutoSize = true;
            label_age.Location = new Point(6, 79);
            label_age.Name = "label_age";
            label_age.Size = new Size(32, 17);
            label_age.TabIndex = 2;
            label_age.Text = "年龄";
            // 
            // label_gender
            // 
            label_gender.AutoSize = true;
            label_gender.Location = new Point(6, 48);
            label_gender.Name = "label_gender";
            label_gender.Size = new Size(32, 17);
            label_gender.TabIndex = 1;
            label_gender.Text = "性别";
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(6, 17);
            label_name.Name = "label_name";
            label_name.Size = new Size(32, 17);
            label_name.TabIndex = 0;
            label_name.Text = "姓名";
            // 
            // comboBox_privilege_input
            // 
            comboBox_privilege_input.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_privilege_input.FormattingEnabled = true;
            comboBox_privilege_input.Items.AddRange(new object[] { "USER_LEVEL", "ADMIN_LEVEL", "SYSADMIN_LEVEL" });
            comboBox_privilege_input.Location = new Point(347, 84);
            comboBox_privilege_input.Name = "comboBox_privilege_input";
            comboBox_privilege_input.Size = new Size(121, 25);
            comboBox_privilege_input.TabIndex = 8;
            // 
            // textBox_username_input
            // 
            textBox_username_input.Location = new Point(347, 49);
            textBox_username_input.Name = "textBox_username_input";
            textBox_username_input.Size = new Size(121, 23);
            textBox_username_input.TabIndex = 7;
            // 
            // label_privilege_input
            // 
            label_privilege_input.AutoSize = true;
            label_privilege_input.BackColor = Color.Transparent;
            label_privilege_input.Location = new Point(271, 87);
            label_privilege_input.Name = "label_privilege_input";
            label_privilege_input.Size = new Size(56, 17);
            label_privilege_input.TabIndex = 6;
            label_privilege_input.Text = "用户权限";
            // 
            // label_username_hint
            // 
            label_username_hint.AutoSize = true;
            label_username_hint.BackColor = Color.Transparent;
            label_username_hint.Location = new Point(271, 52);
            label_username_hint.Name = "label_username_hint";
            label_username_hint.Size = new Size(44, 17);
            label_username_hint.TabIndex = 5;
            label_username_hint.Text = "用户名";
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(240, 415);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(75, 23);
            button_cancel.TabIndex = 10;
            button_cancel.Text = "取消";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(532, 418);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button_cancel);
            Controls.Add(panel_optional);
            Controls.Add(comboBox_privilege_input);
            Controls.Add(textBox_username_input);
            Controls.Add(label_privilege_input);
            Controls.Add(label_username_hint);
            Name = "UserInfoForm";
            Text = "UserInfo";
            panel_optional.ResumeLayout(false);
            panel_optional.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_optional;
        private TextBox textBox_hobby_input;
        private TextBox textBox_profession_input;
        private TextBox textBox_email_input;
        private ComboBox comboBox_gender_input;
        private TextBox textBox_age_input;
        private TextBox textBox_name_input;
        private Label label_hobby;
        private Label label_profession;
        private Label label_email;
        private Label label_age;
        private Label label_gender;
        private Label label_name;
        private ComboBox comboBox_privilege_input;
        private TextBox textBox_username_input;
        private Label label_privilege_input;
        private Label label_username_hint;
        private Button button_cancel;
        private Button button1;
    }
}