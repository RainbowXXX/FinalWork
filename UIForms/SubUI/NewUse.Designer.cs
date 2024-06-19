namespace FinalWork.UIForms
{
    partial class NewUse
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
            label_username_hint = new Label();
            label2 = new Label();
            label_confirmPassword_hint = new Label();
            textBox_username_input = new TextBox();
            textBox_confirmPassword_input = new TextBox();
            textBox_password_input = new TextBox();
            button_register = new Button();
            SuspendLayout();
            // 
            // label_username_hint
            // 
            label_username_hint.AutoSize = true;
            label_username_hint.Location = new Point(74, 60);
            label_username_hint.Name = "label_username_hint";
            label_username_hint.Size = new Size(44, 17);
            label_username_hint.TabIndex = 0;
            label_username_hint.Text = "用户名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 96);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 1;
            label2.Text = "密码";
            // 
            // label_confirmPassword_hint
            // 
            label_confirmPassword_hint.AutoSize = true;
            label_confirmPassword_hint.Location = new Point(74, 132);
            label_confirmPassword_hint.Name = "label_confirmPassword_hint";
            label_confirmPassword_hint.Size = new Size(56, 17);
            label_confirmPassword_hint.TabIndex = 2;
            label_confirmPassword_hint.Text = "确认密码";
            // 
            // textBox_username_input
            // 
            textBox_username_input.Location = new Point(147, 57);
            textBox_username_input.Name = "textBox_username_input";
            textBox_username_input.Size = new Size(100, 23);
            textBox_username_input.TabIndex = 3;
            // 
            // textBox_confirmPassword_input
            // 
            textBox_confirmPassword_input.Location = new Point(147, 129);
            textBox_confirmPassword_input.Name = "textBox_confirmPassword_input";
            textBox_confirmPassword_input.PasswordChar = '*';
            textBox_confirmPassword_input.Size = new Size(100, 23);
            textBox_confirmPassword_input.TabIndex = 4;
            // 
            // textBox_password_input
            // 
            textBox_password_input.Location = new Point(147, 93);
            textBox_password_input.Name = "textBox_password_input";
            textBox_password_input.PasswordChar = '*';
            textBox_password_input.Size = new Size(100, 23);
            textBox_password_input.TabIndex = 5;
            // 
            // button_register
            // 
            button_register.Location = new Point(125, 182);
            button_register.Name = "button_register";
            button_register.Size = new Size(75, 23);
            button_register.TabIndex = 6;
            button_register.Text = "注册";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // NewUse
            // 
            AcceptButton = button_register;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 266);
            Controls.Add(button_register);
            Controls.Add(textBox_password_input);
            Controls.Add(textBox_confirmPassword_input);
            Controls.Add(textBox_username_input);
            Controls.Add(label_confirmPassword_hint);
            Controls.Add(label2);
            Controls.Add(label_username_hint);
            Name = "NewUse";
            Text = "注册管理员";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_username_hint;
        private Label label2;
        private Label label_confirmPassword_hint;
        private TextBox textBox_username_input;
        private TextBox textBox_confirmPassword_input;
        private TextBox textBox_password_input;
        private Button button_register;
    }
}