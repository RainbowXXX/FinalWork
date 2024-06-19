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
    public partial class QueryBooksForm : Form
    {
        private List<BookEntity> _bookEntities;
        private List<BookEntity> bookEntities {
            get { return _bookEntities; }
            set {
                this.textBox_bookid_input.Enabled = false;
                this.textBox_inventory_input.Enabled = false;
                if (!Equals(_bookEntities, value))
                {
                    _bookEntities = value;
                    refresh_content();
                }
            } 
        }

        public QueryBooksForm()
        {
            InitializeComponent();
            refresh_data();
        }

        private void listView_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDetail();
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

        }

        public void refresh_data()
        {
            bookEntities = SqlHandler.Instance.conn.Query<BookEntity>("SELECT * FROM books;").ToList();
        }

        public void refresh_content()
        {
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

        private void button_find_Click(object sender, EventArgs e)
        {
            BookEntity book = new BookEntity(
                0,
                textBox_bookname_input.Text         == string.Empty ? ".*?" : textBox_bookname_input.Text   ,
                textBox_author_input.Text           == string.Empty ? ".*?" : textBox_author_input.Text     ,
                textBox_description_input.Text      == string.Empty ? ".*?" : textBox_description_input.Text,
                textBox_ISBN_input.Text             == string.Empty ? ".*?" : textBox_ISBN_input.Text       ,
                0
                );
            bookEntities = BookTools.FindBook(book) ?? new List<BookEntity>();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            refresh_data();
        }
    }
}
