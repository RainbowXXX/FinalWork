namespace FinalWork.UIForms
{
    partial class PasswdChange
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
            label_old_passwd_hint = new Label();
            label_new_passwd_hint = new Label();
            label_confirm_password_hint = new Label();
            textBox_username_input = new TextBox();
            textBox_old_passwd_input = new TextBox();
            textBox_new_passwd_input = new TextBox();
            textBox_confirm_password_input = new TextBox();
            button_cancel = new Button();
            button_apply = new Button();
            SuspendLayout();
            // 
            // label_username_hint
            // 
            label_username_hint.AutoSize = true;
            label_username_hint.Location = new Point(80, 64);
            label_username_hint.Name = "label_username_hint";
            label_username_hint.Size = new Size(44, 17);
            label_username_hint.TabIndex = 0;
            label_username_hint.Text = "用户名";
            // 
            // label_old_passwd_hint
            // 
            label_old_passwd_hint.AutoSize = true;
            label_old_passwd_hint.Location = new Point(80, 93);
            label_old_passwd_hint.Name = "label_old_passwd_hint";
            label_old_passwd_hint.Size = new Size(44, 17);
            label_old_passwd_hint.TabIndex = 1;
            label_old_passwd_hint.Text = "旧密码";
            // 
            // label_new_passwd_hint
            // 
            label_new_passwd_hint.AutoSize = true;
            label_new_passwd_hint.Location = new Point(80, 122);
            label_new_passwd_hint.Name = "label_new_passwd_hint";
            label_new_passwd_hint.Size = new Size(44, 17);
            label_new_passwd_hint.TabIndex = 2;
            label_new_passwd_hint.Text = "新密码";
            // 
            // label_confirm_password_hint
            // 
            label_confirm_password_hint.AutoSize = true;
            label_confirm_password_hint.Location = new Point(69, 151);
            label_confirm_password_hint.Name = "label_confirm_password_hint";
            label_confirm_password_hint.Size = new Size(56, 17);
            label_confirm_password_hint.TabIndex = 3;
            label_confirm_password_hint.Text = "确认密码";
            // 
            // textBox_username_input
            // 
            textBox_username_input.Location = new Point(129, 61);
            textBox_username_input.Name = "textBox_username_input";
            textBox_username_input.Size = new Size(100, 23);
            textBox_username_input.TabIndex = 4;
            // 
            // textBox_old_passwd_input
            // 
            textBox_old_passwd_input.Location = new Point(129, 90);
            textBox_old_passwd_input.Name = "textBox_old_passwd_input";
            textBox_old_passwd_input.PasswordChar = '*';
            textBox_old_passwd_input.Size = new Size(100, 23);
            textBox_old_passwd_input.TabIndex = 5;
            // 
            // textBox_new_passwd_input
            // 
            textBox_new_passwd_input.Location = new Point(129, 119);
            textBox_new_passwd_input.Name = "textBox_new_passwd_input";
            textBox_new_passwd_input.PasswordChar = '*';
            textBox_new_passwd_input.Size = new Size(100, 23);
            textBox_new_passwd_input.TabIndex = 6;
            // 
            // textBox_confirm_password_input
            // 
            textBox_confirm_password_input.Location = new Point(129, 148);
            textBox_confirm_password_input.Name = "textBox_confirm_password_input";
            textBox_confirm_password_input.PasswordChar = '*';
            textBox_confirm_password_input.Size = new Size(100, 23);
            textBox_confirm_password_input.TabIndex = 7;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(26, 207);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(75, 23);
            button_cancel.TabIndex = 8;
            button_cancel.Text = "取消";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // button_apply
            // 
            button_apply.Location = new Point(208, 207);
            button_apply.Name = "button_apply";
            button_apply.Size = new Size(75, 23);
            button_apply.TabIndex = 9;
            button_apply.Text = "确认";
            button_apply.UseVisualStyleBackColor = true;
            button_apply.Click += button_apply_Click;
            // 
            // PasswdChange
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 279);
            Controls.Add(button_apply);
            Controls.Add(button_cancel);
            Controls.Add(textBox_confirm_password_input);
            Controls.Add(textBox_new_passwd_input);
            Controls.Add(textBox_old_passwd_input);
            Controls.Add(textBox_username_input);
            Controls.Add(label_confirm_password_hint);
            Controls.Add(label_new_passwd_hint);
            Controls.Add(label_old_passwd_hint);
            Controls.Add(label_username_hint);
            Name = "PasswdChange";
            Text = "修改密码";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_username_hint;
        private Label label_old_passwd_hint;
        private Label label_new_passwd_hint;
        private Label label_confirm_password_hint;
        private TextBox textBox_username_input;
        private TextBox textBox_old_passwd_input;
        private TextBox textBox_new_passwd_input;
        private TextBox textBox_confirm_password_input;
        private Button button_cancel;
        private Button button_apply;
    }
}