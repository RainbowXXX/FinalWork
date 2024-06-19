using Dapper;
using FinalWork.Configs;
using FinalWork.Entities;
using FinalWork.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWork.UIForms.SubUI
{
    public partial class BorrowSituationForm : Form
    {
        public BorrowSituationForm()
        {
            InitializeComponent();
            List<BorrowEntity> borrowEntities = SqlHandler.Instance.conn.Query<BorrowEntity>("SELECT * FROM borrow;").ToList();

            int idx = 1;
            foreach (var borrowEntity in borrowEntities)
            {
                ListViewItem item = new ListViewItem((idx++).ToString());
                item.SubItems.Add(UserTools.GetUserInfo(borrowEntity.Uid)?.UserName ?? throw new ArgumentNullException());
                item.SubItems.Add(BookTools.FindBook(borrowEntity.Bid)?.Title ?? throw new ArgumentNullException());
                item.SubItems.Add(borrowEntity.BorrowTime.ToString());
                if (!borrowEntity.IsReturned) {
                    item.SubItems.Add(borrowEntity.BorrowTime < DateTime.Now.AddMonths(-1).AddDays(-15) ? "失信未还" : borrowEntity.BorrowTime < DateTime.Now.AddMonths(-1) ? "逾期未还": "未归还");
                }
                else {
                    item.SubItems.Add("已归还");
                }

                listView1.Items.Add(item);
            }

            comboBox1.Text = "所有记录";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query_str = "SELECT * FROM borrow;";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    query_str = "SELECT * FROM borrow;";
                    break;
                case 1:
                    query_str = "SELECT * FROM borrow WHERE is_returned = 1;";
                    break;
                case 2:
                    query_str = "SELECT * FROM borrow WHERE is_returned = 0";
                    break;
                case 3:
                    query_str = "SELECT * FROM borrow WHERE is_returned = 0 AND borrow_time >= @BorrowTime2 AND borrow_time < @BorrowTime1;";
                    break;
                case 5:
                    query_str = "SELECT * FROM borrow WHERE is_returned = 0 AND borrow_time < @BorrowTime2;";
                    break;
                default:
                    query_str = "SELECT * FROM borrow;";
                    break;
            }

            var optionalParams = new { BorrowTime1 = DateTime.Now.AddMonths(-1), BorrowTime2 = DateTime.Now.AddMonths(-1).AddDays(-15) };
            List<BorrowEntity> borrowEntities = SqlHandler.Instance.conn.Query<BorrowEntity>(query_str, optionalParams).ToList();

            int idx = 1;
            listView1.Items.Clear();
            foreach (var borrowEntity in borrowEntities)
            {
                ListViewItem item = new ListViewItem((idx++).ToString());
                item.SubItems.Add(UserTools.GetUserInfo(borrowEntity.Uid)?.UserName ?? throw new ArgumentNullException());
                item.SubItems.Add(BookTools.FindBook(borrowEntity.Bid)?.Title ?? throw new ArgumentNullException());
                item.SubItems.Add(borrowEntity.BorrowTime.ToString());
                if (!borrowEntity.IsReturned)
                {
                    item.SubItems.Add(borrowEntity.BorrowTime < DateTime.Now.AddMonths(-1).AddDays(-15) ? "失信未还" : borrowEntity.BorrowTime < DateTime.Now.AddMonths(-1) ? "逾期未还" : "未归还");
                }
                else
                {
                    item.SubItems.Add("已归还");
                }
                listView1.Items.Add(item);
            }
        }
    }
}
