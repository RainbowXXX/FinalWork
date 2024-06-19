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
    public partial class SysAdminUI : Form
    {
        public SysAdminUI()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 账户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserInfoAdminForm().Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }
    }
}
