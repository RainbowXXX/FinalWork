namespace FinalWork.UIForms.SubUI
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            listView3 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listView4 = new ListView();
            columnHeader8 = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3 });
            listView1.Location = new Point(27, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(156, 398);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "用户名";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "借阅频率";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4 });
            listView2.Location = new Point(215, 40);
            listView2.Name = "listView2";
            listView2.Size = new Size(97, 398);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "图书名";
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader5, columnHeader6, columnHeader7 });
            listView3.Location = new Point(477, 40);
            listView3.Name = "listView3";
            listView3.Size = new Size(292, 398);
            listView3.TabIndex = 2;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "用户名";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "用户姓名";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "未还书籍";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "借阅时间";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 3;
            label1.Text = "活跃读者列表";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(215, 20);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 4;
            label2.Text = "最热图书统计";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(478, 20);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 5;
            label3.Text = "失信读者列表";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(345, 20);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 6;
            label4.Text = "最热作者统计";
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader8 });
            listView4.Location = new Point(345, 40);
            listView4.Name = "listView4";
            listView4.Size = new Size(97, 398);
            listView4.TabIndex = 7;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "作者";
            // 
            // StatisticForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(listView4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Name = "StatisticForm";
            Text = "StatisticForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label4;
        private ListView listView4;
        private ColumnHeader columnHeader8;
    }
}