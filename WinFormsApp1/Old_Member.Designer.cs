//using Inventory;
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
            label2 = new Label();
            bookBindingSource = new BindingSource(components);
            bookBindingSource1 = new BindingSource(components);
            label3 = new Label();
            BOOKS_COMBO = new ComboBox();
            DVD_COMBO = new ComboBox();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            CHECKOUT = new Label();
            button4 = new Button();
            button5 = new Button();
            Delete_Index = new TextBox();
            label5 = new Label();
            Total_Check = new Label();
            CheckOut_Final = new Button();
            Search_label = new Label();
            SearchBooks_label = new Label();
            SearchDVD_label = new Label();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 45);
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
            old_name.ForeColor = SystemColors.InactiveCaptionText;
            old_name.Location = new Point(41, 73);
            old_name.Margin = new Padding(4, 3, 4, 3);
            old_name.MaxLength = 16;
            old_name.Name = "old_name";
            old_name.Size = new Size(84, 23);
            old_name.TabIndex = 1;
            // 
            // phone_number
            // 
            phone_number.Location = new Point(141, 73);
            phone_number.Margin = new Padding(4, 3, 4, 3);
            phone_number.MaxLength = 11;
            phone_number.Name = "phone_number";
            phone_number.Size = new Size(116, 23);
            phone_number.TabIndex = 2;
            phone_number.KeyPress += phone_number_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 4;
            label2.Text = "Phone Number";
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // bookBindingSource1
            // 
            bookBindingSource1.DataSource = typeof(Book);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 152);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 7;
            label3.Text = "Book_Name";
            // 
            // BOOKS_COMBO
            // 
            BOOKS_COMBO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            BOOKS_COMBO.AutoCompleteSource = AutoCompleteSource.CustomSource;
            BOOKS_COMBO.DataSource = bookBindingSource1;
            BOOKS_COMBO.DisplayMember = "Name";
            BOOKS_COMBO.FormattingEnabled = true;
            BOOKS_COMBO.Location = new Point(41, 179);
            BOOKS_COMBO.Name = "BOOKS_COMBO";
            BOOKS_COMBO.Size = new Size(188, 23);
            BOOKS_COMBO.TabIndex = 8;
            BOOKS_COMBO.ValueMember = "Name";
            // 
            // DVD_COMBO
            // 
            DVD_COMBO.FormattingEnabled = true;
            DVD_COMBO.Location = new Point(41, 325);
            DVD_COMBO.Name = "DVD_COMBO";
            DVD_COMBO.Size = new Size(188, 23);
            DVD_COMBO.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 298);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "DVD_Name";
            // 
            // button2
            // 
            button2.Location = new Point(264, 179);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Add Book";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(264, 325);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "Add DVD";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CHECKOUT
            // 
            CHECKOUT.Location = new Point(363, 45);
            CHECKOUT.Name = "CHECKOUT";
            CHECKOUT.Size = new Size(261, 228);
            CHECKOUT.TabIndex = 15;
            // 
            // button4
            // 
            button4.Location = new Point(490, 312);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 16;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(264, 73);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 17;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Delete_Index
            // 
            Delete_Index.Location = new Point(457, 312);
            Delete_Index.Name = "Delete_Index";
            Delete_Index.Size = new Size(27, 23);
            Delete_Index.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 20);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 19;
            label5.Text = "Checkout:";
            // 
            // Total_Check
            // 
            Total_Check.AutoSize = true;
            Total_Check.Location = new Point(490, 282);
            Total_Check.Name = "Total_Check";
            Total_Check.Size = new Size(53, 15);
            Total_Check.TabIndex = 20;
            Total_Check.Text = "Total : $0";
            // 
            // CheckOut_Final
            // 
            CheckOut_Final.Location = new Point(411, 341);
            CheckOut_Final.Name = "CheckOut_Final";
            CheckOut_Final.Size = new Size(180, 71);
            CheckOut_Final.TabIndex = 21;
            CheckOut_Final.Text = "Complete Payment";
            CheckOut_Final.UseVisualStyleBackColor = true;
            CheckOut_Final.Click += CheckOut_Final_Click;
            // 
            // Search_label
            // 
            Search_label.AutoSize = true;
            Search_label.Location = new Point(43, 103);
            Search_label.Name = "Search_label";
            Search_label.Size = new Size(0, 15);
            Search_label.TabIndex = 22;
            // 
            // SearchBooks_label
            // 
            SearchBooks_label.AutoSize = true;
            SearchBooks_label.Location = new Point(40, 210);
            SearchBooks_label.Name = "SearchBooks_label";
            SearchBooks_label.Size = new Size(0, 15);
            SearchBooks_label.TabIndex = 23;
            // 
            // SearchDVD_label
            // 
            SearchDVD_label.AutoSize = true;
            SearchDVD_label.Location = new Point(43, 351);
            SearchDVD_label.Name = "SearchDVD_label";
            SearchDVD_label.Size = new Size(0, 15);
            SearchDVD_label.TabIndex = 24;
            // 
            // Old_Member
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 463);
            Controls.Add(SearchDVD_label);
            Controls.Add(SearchBooks_label);
            Controls.Add(Search_label);
            Controls.Add(CheckOut_Final);
            Controls.Add(Total_Check);
            Controls.Add(label5);
            Controls.Add(Delete_Index);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(CHECKOUT);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(DVD_COMBO);
            Controls.Add(label4);
            Controls.Add(BOOKS_COMBO);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(phone_number);
            Controls.Add(old_name);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Old_Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Complete Checkout";
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox old_name;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.Label label2;
        private BindingSource bookBindingSource;
        private BindingSource bookBindingSource1;
        private Label label3;
        private ComboBox BOOKS_COMBO;
        private ComboBox DVD_COMBO;
        private Label label4;
        private Button button2;
        private Button button3;
        private Label CHECKOUT;
        private Button button4;
        private Button button5;
        private TextBox Delete_Index;
        private Label label5;
        private Label Total_Check;
        private Button CheckOut_Final;
        private Label Search_label;
        private Label SearchBooks_label;
        private Label SearchDVD_label;
    }
}