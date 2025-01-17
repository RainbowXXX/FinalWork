﻿using FinalWork.UIForms.SubUI;
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
    public partial class UserUI : Form
    {
        public UserUI()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 借阅管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BorrowReturnForm().Show();
        }

        private void 图书查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QueryBooksForm().Show();
        }

        private void 账户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserInfoForm().Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }

        private void 图书推荐榜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserStatisticForm().Show();
        }
    }
}
