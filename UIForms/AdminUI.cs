using FinalWork.UIForms.SubUI;
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
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookInfoForm().Show();
        }

        private void 账号管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserInfoAdminForm().Show();
        }

        private void 数统计据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StatisticForm().Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }

        private void 借阅情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BorrowSituationForm().Show();
        }

        private void 用户积分ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserPointsForm().Show();
        }
    }
}
