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

namespace FinalWork.UIForms
{
    public partial class BorrowReturnForm : Form
    {
        List<BookEntity> bookEntities = new List<BookEntity>();
        List<BorrowEntity> borrowEntities = new List<BorrowEntity>();
        public BorrowReturnForm()
        {
            InitializeComponent();
            clearDetail();
            refresh_content();
        }

        private void clearDetail()
        {
            this.textBox_bookid_input.Text = string.Empty;
            this.textBox_bookname_input.Text = string.Empty;
            this.textBox_author_input.Text = string.Empty;
            this.textBox_description_input.Text = string.Empty;
            this.textBox_ISBN_input.Text = string.Empty;
            this.textBox_inventory_input.Text = string.Empty;

            this.textBox_bookid_input.Enabled = false;
            this.textBox_bookname_input.Enabled = false;
            this.textBox_author_input.Enabled = false;
            this.textBox_description_input.Enabled = false;
            this.textBox_ISBN_input.Enabled = false;
            this.textBox_inventory_input.Enabled = false;
        }

        private void ShowDetail()
        {
            var selectedItems = listView_users.SelectedItems;
            if (selectedItems.Count <= 0)
            {
                clearDetail();
                return;
            }

            var selectedSubItems = selectedItems[0].SubItems;

            this.textBox_bookid_input.Text = selectedSubItems[0].Text;
            this.textBox_bookname_input.Text = selectedSubItems[1].Text;
            this.textBox_author_input.Text = selectedSubItems[2].Text;
            this.textBox_description_input.Text = selectedSubItems[3].Text;
            this.textBox_ISBN_input.Text = selectedSubItems[4].Text;
            this.textBox_inventory_input.Text = selectedSubItems[5].Text;

            this.textBox_bookid_input.Enabled = false;
            this.textBox_bookname_input.Enabled = false;
            this.textBox_author_input.Enabled = false;
            this.textBox_description_input.Enabled = false;
            this.textBox_ISBN_input.Enabled = false;
            this.textBox_inventory_input.Enabled = false;
        }

        public void refresh_content()
        {
            bookEntities = BookTools.GetBooks();
            borrowEntities = BorrowTools.GetBorrows();

            listView_users.Items.Clear();
            foreach (var book in bookEntities)
            {
                ListViewItem item = new ListViewItem(book.Id.ToString());
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Description);
                item.SubItems.Add(book.ISBN);
                item.SubItems.Add(book.Inventory.ToString());


                listView_users.Items.Add(item);
            }

            foreach (ColumnHeader column in listView_users.Columns)
            {
                column.Width = -2;
            }

            listView1.Items.Clear();
            foreach (var borrow in borrowEntities)
            {
                BookEntity? book = BookTools.FindBook(borrow.Bid);
                ListViewItem item = new ListViewItem(borrow.Id.ToString());
                item.SubItems.Add(borrow.Bid.ToString());
                item.SubItems.Add(book?.Id.ToString() ?? string.Empty);
                item.SubItems.Add(borrow.BorrowTime.ToString());


                listView1.Items.Add(item);
            }

            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2;
            }
        }

        private void listView_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItems = listView_users.SelectedItems;
            if (selectedItems.Count <= 0) return;

            var selectedSubItems = selectedItems[0].SubItems;
            BorrowEntity borrow = new BorrowEntity(0, GlobalTools.cur_uid, int.Parse(selectedSubItems[0].Text), false, DateTime.Now);
            BorrowTools.BorrowBook(borrow);
            refresh_content();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedItems = listView1.SelectedItems;
            if (selectedItems.Count <= 0) return;

            var selectedSubItems = selectedItems[0].SubItems;
            BorrowEntity borrow = new BorrowEntity(int.Parse(selectedSubItems[0].Text), GlobalTools.cur_uid, int.Parse(selectedSubItems[1].Text), false, DateTime.Now);
            BorrowTools.return_book(borrow);
            refresh_content();
        }
    }
}
