namespace FinalWork.UIForms
{
    partial class QueryBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryBooksForm));
            column_inventory = new ColumnHeader();
            textBox_bookid_input = new TextBox();
            textBox_inventory_input = new TextBox();
            label_inventory_hint = new Label();
            textBox_ISBN_input = new TextBox();
            label_ISBN_hint = new Label();
            textBox_description_input = new TextBox();
            label_description_hint = new Label();
            textBox_author_input = new TextBox();
            label_author_hint = new Label();
            textBox_bookname_input = new TextBox();
            column_description = new ColumnHeader();
            column_author = new ColumnHeader();
            column_title = new ColumnHeader();
            column_id = new ColumnHeader();
            listView_users = new ListView();
            column_ISBN = new ColumnHeader();
            label_bookname_hint = new Label();
            button_find = new Button();
            button_cancel = new Button();
            label_bookid_hint = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // column_inventory
            // 
            column_inventory.Text = "库存";
            column_inventory.Width = 36;
            // 
            // textBox_bookid_input
            // 
            textBox_bookid_input.Location = new Point(85, 23);
            textBox_bookid_input.Name = "textBox_bookid_input";
            textBox_bookid_input.Size = new Size(121, 23);
            textBox_bookid_input.TabIndex = 18;
            // 
            // textBox_inventory_input
            // 
            textBox_inventory_input.Location = new Point(85, 168);
            textBox_inventory_input.Name = "textBox_inventory_input";
            textBox_inventory_input.Size = new Size(121, 23);
            textBox_inventory_input.TabIndex = 17;
            // 
            // label_inventory_hint
            // 
            label_inventory_hint.AutoSize = true;
            label_inventory_hint.Location = new Point(9, 171);
            label_inventory_hint.Name = "label_inventory_hint";
            label_inventory_hint.Size = new Size(32, 17);
            label_inventory_hint.TabIndex = 16;
            label_inventory_hint.Text = "库存";
            // 
            // textBox_ISBN_input
            // 
            textBox_ISBN_input.Location = new Point(85, 139);
            textBox_ISBN_input.Name = "textBox_ISBN_input";
            textBox_ISBN_input.Size = new Size(121, 23);
            textBox_ISBN_input.TabIndex = 15;
            // 
            // label_ISBN_hint
            // 
            label_ISBN_hint.AutoSize = true;
            label_ISBN_hint.Location = new Point(9, 142);
            label_ISBN_hint.Name = "label_ISBN_hint";
            label_ISBN_hint.Size = new Size(49, 17);
            label_ISBN_hint.TabIndex = 14;
            label_ISBN_hint.Text = "ISBN号";
            // 
            // textBox_description_input
            // 
            textBox_description_input.Location = new Point(85, 110);
            textBox_description_input.Name = "textBox_description_input";
            textBox_description_input.Size = new Size(121, 23);
            textBox_description_input.TabIndex = 13;
            // 
            // label_description_hint
            // 
            label_description_hint.AutoSize = true;
            label_description_hint.Location = new Point(9, 113);
            label_description_hint.Name = "label_description_hint";
            label_description_hint.Size = new Size(32, 17);
            label_description_hint.TabIndex = 12;
            label_description_hint.Text = "描述";
            // 
            // textBox_author_input
            // 
            textBox_author_input.Location = new Point(85, 81);
            textBox_author_input.Name = "textBox_author_input";
            textBox_author_input.Size = new Size(121, 23);
            textBox_author_input.TabIndex = 11;
            // 
            // label_author_hint
            // 
            label_author_hint.AutoSize = true;
            label_author_hint.Location = new Point(9, 84);
            label_author_hint.Name = "label_author_hint";
            label_author_hint.Size = new Size(32, 17);
            label_author_hint.TabIndex = 10;
            label_author_hint.Text = "作者";
            // 
            // textBox_bookname_input
            // 
            textBox_bookname_input.Location = new Point(85, 52);
            textBox_bookname_input.Name = "textBox_bookname_input";
            textBox_bookname_input.Size = new Size(121, 23);
            textBox_bookname_input.TabIndex = 9;
            // 
            // column_description
            // 
            column_description.Text = "描述";
            // 
            // column_author
            // 
            column_author.Text = "作者";
            column_author.Width = 36;
            // 
            // column_title
            // 
            column_title.Tag = "";
            column_title.Text = "书名";
            column_title.Width = 36;
            // 
            // column_id
            // 
            column_id.Tag = "";
            column_id.Text = "id";
            column_id.Width = 48;
            // 
            // listView_users
            // 
            listView_users.Columns.AddRange(new ColumnHeader[] { column_id, column_title, column_author, column_description, column_ISBN, column_inventory });
            listView_users.FullRowSelect = true;
            listView_users.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_users.Location = new Point(12, 33);
            listView_users.Name = "listView_users";
            listView_users.Size = new Size(440, 407);
            listView_users.TabIndex = 4;
            listView_users.UseCompatibleStateImageBehavior = false;
            listView_users.View = View.Details;
            listView_users.SelectedIndexChanged += listView_users_SelectedIndexChanged;
            // 
            // column_ISBN
            // 
            column_ISBN.Text = "ISBN号";
            column_ISBN.Width = 36;
            // 
            // label_bookname_hint
            // 
            label_bookname_hint.AutoSize = true;
            label_bookname_hint.Location = new Point(9, 55);
            label_bookname_hint.Name = "label_bookname_hint";
            label_bookname_hint.Size = new Size(32, 17);
            label_bookname_hint.TabIndex = 8;
            label_bookname_hint.Text = "书名";
            // 
            // button_find
            // 
            button_find.Location = new Point(249, 380);
            button_find.Name = "button_find";
            button_find.Size = new Size(75, 23);
            button_find.TabIndex = 7;
            button_find.Text = "查找";
            button_find.UseVisualStyleBackColor = true;
            button_find.Click += button_find_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(9, 380);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(75, 23);
            button_cancel.TabIndex = 6;
            button_cancel.Text = "取消";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // label_bookid_hint
            // 
            label_bookid_hint.AutoSize = true;
            label_bookid_hint.Location = new Point(9, 26);
            label_bookid_hint.Name = "label_bookid_hint";
            label_bookid_hint.Size = new Size(31, 17);
            label_bookid_hint.TabIndex = 0;
            label_bookid_hint.Text = "书id";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(textBox_bookid_input);
            groupBox1.Controls.Add(textBox_inventory_input);
            groupBox1.Controls.Add(label_inventory_hint);
            groupBox1.Controls.Add(textBox_ISBN_input);
            groupBox1.Controls.Add(label_ISBN_hint);
            groupBox1.Controls.Add(textBox_description_input);
            groupBox1.Controls.Add(label_description_hint);
            groupBox1.Controls.Add(textBox_author_input);
            groupBox1.Controls.Add(label_author_hint);
            groupBox1.Controls.Add(textBox_bookname_input);
            groupBox1.Controls.Add(label_bookname_hint);
            groupBox1.Controls.Add(button_find);
            groupBox1.Controls.Add(button_cancel);
            groupBox1.Controls.Add(label_bookid_hint);
            groupBox1.Location = new Point(458, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 411);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "书籍信息";
            // 
            // QueryBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(listView_users);
            Controls.Add(groupBox1);
            Name = "QueryBooksForm";
            Text = "QueryBooks";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ColumnHeader column_inventory;
        private TextBox textBox_bookid_input;
        private TextBox textBox_inventory_input;
        private Label label_inventory_hint;
        private TextBox textBox_ISBN_input;
        private Label label_ISBN_hint;
        private TextBox textBox_description_input;
        private Label label_description_hint;
        private TextBox textBox_author_input;
        private Label label_author_hint;
        private TextBox textBox_bookname_input;
        private ColumnHeader column_description;
        private ColumnHeader column_author;
        private ColumnHeader column_title;
        private ColumnHeader column_id;
        private ListView listView_users;
        private ColumnHeader column_ISBN;
        private Label label_bookname_hint;
        private Button button_find;
        private Button button_cancel;
        private Label label_bookid_hint;
        private GroupBox groupBox1;
    }
}