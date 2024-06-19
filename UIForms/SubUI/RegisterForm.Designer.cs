namespace FinalWork.UIForms.SubUI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            button_register = new Button();
            textBox_password_input = new TextBox();
            textBox_confirmPassword_input = new TextBox();
            textBox_username_input = new TextBox();
            label_confirmPassword_hint = new Label();
            label2 = new Label();
            label_username_hint = new Label();
            SuspendLayout();
            // 
            // button_register
            // 
            button_register.Location = new Point(365, 276);
            button_register.Name = "button_register";
            button_register.Size = new Size(75, 23);
            button_register.TabIndex = 13;
            button_register.Text = "注册";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // textBox_password_input
            // 
            textBox_password_input.Location = new Point(387, 187);
            textBox_password_input.Name = "textBox_password_input";
            textBox_password_input.PasswordChar = '*';
            textBox_password_input.Size = new Size(100, 23);
            textBox_password_input.TabIndex = 12;
            // 
            // textBox_confirmPassword_input
            // 
            textBox_confirmPassword_input.Location = new Point(387, 223);
            textBox_confirmPassword_input.Name = "textBox_confirmPassword_input";
            textBox_confirmPassword_input.PasswordChar = '*';
            textBox_confirmPassword_input.Size = new Size(100, 23);
            textBox_confirmPassword_input.TabIndex = 11;
            // 
            // textBox_username_input
            // 
            textBox_username_input.Location = new Point(387, 151);
            textBox_username_input.Name = "textBox_username_input";
            textBox_username_input.Size = new Size(100, 23);
            textBox_username_input.TabIndex = 10;
            // 
            // label_confirmPassword_hint
            // 
            label_confirmPassword_hint.AutoSize = true;
            label_confirmPassword_hint.BackColor = Color.Transparent;
            label_confirmPassword_hint.Location = new Point(314, 226);
            label_confirmPassword_hint.Name = "label_confirmPassword_hint";
            label_confirmPassword_hint.Size = new Size(56, 17);
            label_confirmPassword_hint.TabIndex = 9;
            label_confirmPassword_hint.Text = "确认密码";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(314, 190);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 8;
            label2.Text = "密码";
            // 
            // label_username_hint
            // 
            label_username_hint.AutoSize = true;
            label_username_hint.BackColor = Color.Transparent;
            label_username_hint.Location = new Point(314, 154);
            label_username_hint.Name = "label_username_hint";
            label_username_hint.Size = new Size(44, 17);
            label_username_hint.TabIndex = 7;
            label_username_hint.Text = "用户名";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button_register);
            Controls.Add(textBox_password_input);
            Controls.Add(textBox_confirmPassword_input);
            Controls.Add(textBox_username_input);
            Controls.Add(label_confirmPassword_hint);
            Controls.Add(label2);
            Controls.Add(label_username_hint);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_register;
        private TextBox textBox_password_input;
        private TextBox textBox_confirmPassword_input;
        private TextBox textBox_username_input;
        private Label label_confirmPassword_hint;
        private Label label2;
        private Label label_username_hint;
    }
}