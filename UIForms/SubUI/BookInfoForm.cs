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
    public partial class BookInfoForm : Form
    {
        List<BookEntity> bookEntities = new List<BookEntity>();
        public BookInfoForm()
        {
            InitializeComponent();
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
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            clearDetail();
            refresh_content();
            return;
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            BookEntity book = new BookEntity(int.Parse(textBox_bookid_input.Text), textBox_bookname_input.Text, textBox_description_input.Text, textBox_author_input.Text, textBox_ISBN_input.Text, int.Parse(textBox_inventory_input.Text));
            BookTools.ModifyBook(book);
            refresh_content();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            BookEntity book = new BookEntity(0, textBox_bookname_input.Text, textBox_author_input.Text, textBox_description_input.Text, textBox_ISBN_input.Text, int.Parse(textBox_inventory_input.Text));
            BookTools.AddBook(book);
            refresh_content();
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
            this.textBox_bookid_input.Enabled = false;
            this.textBox_bookname_input.Text = selectedSubItems[1].Text;
            this.textBox_author_input.Text = selectedSubItems[2].Text;
            this.textBox_description_input.Text = selectedSubItems[3].Text;
            this.textBox_ISBN_input.Text = selectedSubItems[4].Text;
            this.textBox_inventory_input.Text = selectedSubItems[5].Text;

        }

        private void listView_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDetail();
        }

        public void refresh_content()
        {
            bookEntities = SqlHandler.Instance.conn.Query<BookEntity>("SELECT * FROM books;").ToList();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string book_to_del = textBox_bookid_input.Text;
            if (GlobalTools.user_level<UserLoginEntity.PrivilegeLevel.ADMIN_LEVEL)
            {
                MessageBox.Show("没有权限", "删除确认", MessageBoxButtons.OK);
                return;
            }
            if (book_to_del == "")
            {
                MessageBox.Show("请选择书籍", "删除确认", MessageBoxButtons.OK);
                return;
            }
            var ret = MessageBox.Show("是否删除 " + book_to_del + " 书籍?", "删除确认", MessageBoxButtons.OKCancel);
            if (ret != DialogResult.OK) return;
            BookTools.RemoveBook(int.Parse(book_to_del));
            refresh_content();
            return;
        }
    }
}
