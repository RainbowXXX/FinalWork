namespace FinalWork.UIForms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label_uname_hint = new Label();
            label_passwd_hint = new Label();
            textBox_username_input = new TextBox();
            textBox_passwd_input = new TextBox();
            button_login = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label_uname_hint
            // 
            label_uname_hint.AutoSize = true;
            label_uname_hint.BackColor = Color.Transparent;
            label_uname_hint.Location = new Point(296, 161);
            label_uname_hint.Name = "label_uname_hint";
            label_uname_hint.Size = new Size(44, 17);
            label_uname_hint.TabIndex = 0;
            label_uname_hint.Text = "用户名";
            // 
            // label_passwd_hint
            // 
            label_passwd_hint.AutoSize = true;
            label_passwd_hint.BackColor = Color.Transparent;
            label_passwd_hint.Location = new Point(296, 200);
            label_passwd_hint.Name = "label_passwd_hint";
            label_passwd_hint.Size = new Size(32, 17);
            label_passwd_hint.TabIndex = 1;
            label_passwd_hint.Text = "密码";
            // 
            // textBox_username_input
            // 
            textBox_username_input.BackColor = SystemColors.Control;
            textBox_username_input.Location = new Point(346, 158);
            textBox_username_input.Name = "textBox_username_input";
            textBox_username_input.Size = new Size(100, 23);
            textBox_username_input.TabIndex = 2;
            // 
            // textBox_passwd_input
            // 
            textBox_passwd_input.Location = new Point(346, 197);
            textBox_passwd_input.Name = "textBox_passwd_input";
            textBox_passwd_input.PasswordChar = '*';
            textBox_passwd_input.Size = new Size(100, 23);
            textBox_passwd_input.TabIndex = 3;
            // 
            // button_login
            // 
            button_login.Location = new Point(254, 340);
            button_login.Name = "button_login";
            button_login.Size = new Size(75, 23);
            button_login.TabIndex = 4;
            button_login.Text = "登录";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button1
            // 
            button1.Location = new Point(421, 340);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "注册";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AcceptButton = button_login;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button_login);
            Controls.Add(textBox_passwd_input);
            Controls.Add(textBox_username_input);
            Controls.Add(label_passwd_hint);
            Controls.Add(label_uname_hint);
            Name = "LoginForm";
            Text = "登录";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_uname_hint;
        private Label label_passwd_hint;
        private TextBox textBox_username_input;
        private TextBox textBox_passwd_input;
        private Button button_login;
        private Button button1;
    }
}
