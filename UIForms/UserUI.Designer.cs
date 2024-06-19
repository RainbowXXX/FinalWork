﻿namespace FinalWork.UIForms
{
    partial class UserUI
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
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            编辑ToolStripMenuItem = new ToolStripMenuItem();
            借阅管理ToolStripMenuItem = new ToolStripMenuItem();
            图书查询ToolStripMenuItem = new ToolStripMenuItem();
            账户管理ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 文件ToolStripMenuItem, 编辑ToolStripMenuItem, 帮助ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 0;
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
            退出ToolStripMenuItem.Size = new Size(100, 22);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // 编辑ToolStripMenuItem
            // 
            编辑ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 借阅管理ToolStripMenuItem, 图书查询ToolStripMenuItem, 账户管理ToolStripMenuItem });
            编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            编辑ToolStripMenuItem.Size = new Size(44, 21);
            编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 借阅管理ToolStripMenuItem
            // 
            借阅管理ToolStripMenuItem.Name = "借阅管理ToolStripMenuItem";
            借阅管理ToolStripMenuItem.Size = new Size(180, 22);
            借阅管理ToolStripMenuItem.Text = "借阅管理";
            借阅管理ToolStripMenuItem.Click += 借阅管理ToolStripMenuItem_Click;
            // 
            // 图书查询ToolStripMenuItem
            // 
            图书查询ToolStripMenuItem.Name = "图书查询ToolStripMenuItem";
            图书查询ToolStripMenuItem.Size = new Size(180, 22);
            图书查询ToolStripMenuItem.Text = "图书查询";
            图书查询ToolStripMenuItem.Click += 图书查询ToolStripMenuItem_Click;
            // 
            // 账户管理ToolStripMenuItem
            // 
            账户管理ToolStripMenuItem.Name = "账户管理ToolStripMenuItem";
            账户管理ToolStripMenuItem.Size = new Size(180, 22);
            账户管理ToolStripMenuItem.Text = "账户管理";
            账户管理ToolStripMenuItem.Click += 账户管理ToolStripMenuItem_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 193);
            label1.Name = "label1";
            label1.Size = new Size(104, 34);
            label1.TabIndex = 1;
            label1.Text = "欢迎来到\r\n图书借阅管理系统";
            // 
            // UserUI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "UserUI";
            Text = "UserUI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 编辑ToolStripMenuItem;
        private ToolStripMenuItem 借阅管理ToolStripMenuItem;
        private ToolStripMenuItem 图书查询ToolStripMenuItem;
        private ToolStripMenuItem 账户管理ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private Label label1;
    }
}