namespace FinalWork.UIForms
{
    partial class SysAdmin
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
            listView_users = new ListView();
            column_username = new ColumnHeader();
            column_privilege = new ColumnHeader();
            column_name = new ColumnHeader();
            column_gender = new ColumnHeader();
            column_age = new ColumnHeader();
            column_email = new ColumnHeader();
            column_profession = new ColumnHeader();
            column_hobby = new ColumnHeader();
            groupBox1 = new GroupBox();
            button_add = new Button();
            button_cancel = new Button();
            button_change = new Button();
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
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            编辑ToolStripMenuItem = new ToolStripMenuItem();
            更改密码ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            panel_optional.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView_users
            // 
            listView_users.Columns.AddRange(new ColumnHeader[] { column_username, column_privilege, column_name, column_gender, column_age, column_email, column_profession, column_hobby });
            listView_users.FullRowSelect = true;
            listView_users.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_users.Location = new Point(12, 31);
            listView_users.Name = "listView_users";
            listView_users.Size = new Size(440, 407);
            listView_users.TabIndex = 0;
            listView_users.UseCompatibleStateImageBehavior = false;
            listView_users.View = View.Details;
            listView_users.SelectedIndexChanged += listView_users_SelectedIndexChanged;
            // 
            // column_username
            // 
            column_username.Tag = "";
            column_username.Text = "用户名";
            column_username.Width = 48;
            // 
            // column_privilege
            // 
            column_privilege.Tag = "";
            column_privilege.Text = "权限";
            column_privilege.Width = 36;
            // 
            // column_name
            // 
            column_name.Text = "姓名";
            column_name.Width = 36;
            // 
            // column_gender
            // 
            column_gender.Text = "性别";
            column_gender.Width = 36;
            // 
            // column_age
            // 
            column_age.Text = "年龄";
            column_age.Width = 36;
            // 
            // column_email
            // 
            column_email.Text = "邮件";
            column_email.Width = 36;
            // 
            // column_profession
            // 
            column_profession.Text = "职业";
            column_profession.Width = 36;
            // 
            // column_hobby
            // 
            column_hobby.Text = "爱好";
            column_hobby.Width = 172;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_add);
            groupBox1.Controls.Add(button_cancel);
            groupBox1.Controls.Add(button_change);
            groupBox1.Controls.Add(panel_optional);
            groupBox1.Controls.Add(comboBox_privilege_input);
            groupBox1.Controls.Add(textBox_username_input);
            groupBox1.Controls.Add(label_privilege_input);
            groupBox1.Controls.Add(label_username_hint);
            groupBox1.Location = new Point(458, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 411);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "用户信息";
            // 
            // button_add
            // 
            button_add.Location = new Point(249, 380);
            button_add.Name = "button_add";
            button_add.Size = new Size(75, 23);
            button_add.TabIndex = 7;
            button_add.Text = "添加";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(9, 380);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(75, 23);
            button_cancel.TabIndex = 6;
            button_cancel.Text = "取消";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_change
            // 
            button_change.Location = new Point(131, 380);
            button_change.Name = "button_change";
            button_change.Size = new Size(75, 23);
            button_change.TabIndex = 5;
            button_change.Text = "更改";
            button_change.UseVisualStyleBackColor = true;
            button_change.Click += button_change_Click;
            // 
            // panel_optional
            // 
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
            panel_optional.Location = new Point(9, 119);
            panel_optional.Name = "panel_optional";
            panel_optional.Size = new Size(317, 200);
            panel_optional.TabIndex = 4;
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
            comboBox_privilege_input.Location = new Point(85, 58);
            comboBox_privilege_input.Name = "comboBox_privilege_input";
            comboBox_privilege_input.Size = new Size(121, 25);
            comboBox_privilege_input.TabIndex = 3;
            comboBox_privilege_input.SelectedIndexChanged += comboBox_privilege_input_SelectedIndexChanged;
            // 
            // textBox_username_input
            // 
            textBox_username_input.Location = new Point(85, 23);
            textBox_username_input.Name = "textBox_username_input";
            textBox_username_input.Size = new Size(121, 23);
            textBox_username_input.TabIndex = 2;
            // 
            // label_privilege_input
            // 
            label_privilege_input.AutoSize = true;
            label_privilege_input.Location = new Point(9, 61);
            label_privilege_input.Name = "label_privilege_input";
            label_privilege_input.Size = new Size(56, 17);
            label_privilege_input.TabIndex = 1;
            label_privilege_input.Text = "用户权限";
            // 
            // label_username_hint
            // 
            label_username_hint.AutoSize = true;
            label_username_hint.Location = new Point(9, 26);
            label_username_hint.Name = "label_username_hint";
            label_username_hint.Size = new Size(44, 17);
            label_username_hint.TabIndex = 0;
            label_username_hint.Text = "用户名";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 编辑ToolStripMenuItem, 帮助ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 退出ToolStripMenuItem });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(44, 21);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(180, 22);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // 编辑ToolStripMenuItem
            // 
            编辑ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 更改密码ToolStripMenuItem });
            编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            编辑ToolStripMenuItem.Size = new Size(44, 21);
            编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 更改密码ToolStripMenuItem
            // 
            更改密码ToolStripMenuItem.Name = "更改密码ToolStripMenuItem";
            更改密码ToolStripMenuItem.Size = new Size(124, 22);
            更改密码ToolStripMenuItem.Text = "更改密码";
            更改密码ToolStripMenuItem.Click += 更改密码ToolStripMenuItem_Click;
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 关于ToolStripMenuItem });
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(44, 21);
            帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(100, 22);
            关于ToolStripMenuItem.Text = "关于";
            // 
            // SysAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(listView_users);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SysAdmin";
            Text = "系统管理";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel_optional.ResumeLayout(false);
            panel_optional.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView_users;
        private GroupBox groupBox1;
        private ComboBox comboBox_privilege_input;
        private TextBox textBox_username_input;
        private Label label_privilege_input;
        private Label label_username_hint;
        private Panel panel_optional;
        private Label label_hobby;
        private Label label_profession;
        private Label label_email;
        private Label label_age;
        private Label label_gender;
        private Label label_name;
        private TextBox textBox_hobby_input;
        private TextBox textBox_profession_input;
        private TextBox textBox_email_input;
        private ComboBox comboBox_gender_input;
        private TextBox textBox_age_input;
        private TextBox textBox_name_input;
        private ColumnHeader column_username;
        private ColumnHeader column_privilege;
        private Button button_add;
        private Button button_cancel;
        private Button button_change;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 编辑ToolStripMenuItem;
        private ColumnHeader column_name;
        private ColumnHeader column_gender;
        private ColumnHeader column_age;
        private ColumnHeader column_email;
        private ColumnHeader column_profession;
        private ColumnHeader column_hobby;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripMenuItem 更改密码ToolStripMenuItem;
    }
}