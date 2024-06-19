namespace FinalWork.UIForms.SubUI
{
    partial class UserStatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserStatisticForm));
            listView4 = new ListView();
            columnHeader8 = new ColumnHeader();
            label4 = new Label();
            label2 = new Label();
            listView2 = new ListView();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader8 });
            listView4.Location = new Point(417, 36);
            listView4.Name = "listView4";
            listView4.Size = new Size(204, 398);
            listView4.TabIndex = 11;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "作者";
            columnHeader8.Width = 195;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(417, 16);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 10;
            label4.Text = "最热作者统计";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(180, 16);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 9;
            label2.Text = "最热图书统计";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader4 });
            listView2.Location = new Point(180, 36);
            listView2.Name = "listView2";
            listView2.Size = new Size(204, 398);
            listView2.TabIndex = 8;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "图书名";
            columnHeader4.Width = 195;
            // 
            // UserStatisticForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(listView4);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(listView2);
            Name = "UserStatisticForm";
            Text = "UserStatisticForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView4;
        private ColumnHeader columnHeader8;
        private Label label4;
        private Label label2;
        private ListView listView2;
        private ColumnHeader columnHeader4;
    }
}