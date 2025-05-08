using Inventory;
namespace Library_Managment__System
{
    partial class Old_Member
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            old_name = new TextBox();
            phone_number = new TextBox();
            Book_name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Search_btn = new Button();
            bookBindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // old_name
            // 
            old_name.AllowDrop = true;
            old_name.BackColor = SystemColors.Window;
            old_name.ForeColor = SystemColors.Menu;
            old_name.Location = new Point(18, 73);
            old_name.Margin = new Padding(4, 3, 4, 3);
            old_name.Name = "old_name";
            old_name.Size = new Size(116, 23);
            old_name.TabIndex = 1;
            // 
            // phone_number
            // 
            phone_number.Location = new Point(18, 152);
            phone_number.Margin = new Padding(4, 3, 4, 3);
            phone_number.Name = "phone_number";
            phone_number.Size = new Size(116, 23);
            phone_number.TabIndex = 2;
            // 
            // Book_name
            // 
            Book_name.AccessibleDescription = "";
            Book_name.AccessibleName = "";
            Book_name.AllowDrop = true;
            Book_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Book_name.AutoCompleteSource = AutoCompleteSource.HistoryList;
            Book_name.Cursor = Cursors.IBeam;
            Book_name.Location = new Point(18, 260);
            Book_name.Margin = new Padding(4, 3, 4, 3);
            Book_name.Name = "Book_name";
            Book_name.Size = new Size(116, 23);
            Book_name.TabIndex = 3;
            Book_name.TextChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 238);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 5;
            label3.Text = "Book_name";
            // 
            // Search_btn
            // 
            Search_btn.Location = new Point(346, 173);
            Search_btn.Margin = new Padding(4, 3, 4, 3);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(88, 27);
            Search_btn.TabIndex = 6;
            Search_btn.Text = "Search";
            Search_btn.UseVisualStyleBackColor = true;
            Search_btn.Click += Search_btn_Click;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(18, 280);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(116, 79);
            listBox1.TabIndex = 7;
            listBox1.Visible = false;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Old_Member
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 463);
            Controls.Add(listBox1);
            Controls.Add(Search_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Book_name);
            Controls.Add(phone_number);
            Controls.Add(old_name);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Old_Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Old_Member";
            Load += Old_Member_Load;
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox old_name;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.TextBox Book_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Search_btn;
        private BindingSource bookBindingSource;
        private ListBox listBox1;
    }
}