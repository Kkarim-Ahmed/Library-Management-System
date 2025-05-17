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
            Search_btn = new Button();
            bookBindingSource = new BindingSource(components);
            bookBindingSource1 = new BindingSource(components);
            label3 = new Label();
            BOOKS_COMBO = new ComboBox();
            DVD_COMBO = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            CHECKOUT = new Label();
            button4 = new Button();
            button5 = new Button();
            Delete_Index = new TextBox();
            label5 = new Label();
            Total_Check = new Label();
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
            phone_number.TextChanged += phone_number_TextChanged;
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
            // Search_btn
            // 
            Search_btn.Location = new Point(169, 161);
            Search_btn.Margin = new Padding(4, 3, 4, 3);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(88, 23);
            Search_btn.TabIndex = 6;
            Search_btn.Text = "Book Search";
            Search_btn.UseVisualStyleBackColor = true;
            Search_btn.Click += Search_btn_Click;
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
            label3.Location = new Point(41, 134);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 7;
            label3.Text = "Book_Name";
            // 
            // BOOKS_COMBO
            // 
            BOOKS_COMBO.FormattingEnabled = true;
            BOOKS_COMBO.Location = new Point(41, 161);
            BOOKS_COMBO.Name = "BOOKS_COMBO";
            BOOKS_COMBO.Size = new Size(121, 23);
            BOOKS_COMBO.TabIndex = 8;
            // 
            // DVD_COMBO
            // 
            DVD_COMBO.FormattingEnabled = true;
            DVD_COMBO.Location = new Point(41, 251);
            DVD_COMBO.Name = "DVD_COMBO";
            DVD_COMBO.Size = new Size(121, 23);
            DVD_COMBO.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 224);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "DVD_Name";
            // 
            // button1
            // 
            button1.Location = new Point(169, 251);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 10;
            button1.Text = "DVD Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(282, 160);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Add Book";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(282, 250);
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
            CHECKOUT.Click += CHECKOUT_Click;
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
            button5.Location = new Point(282, 73);
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
            Total_Check.Click += Total_Check_Click;
            // 
            // Old_Member
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 463);
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
            Controls.Add(button1);
            Controls.Add(BOOKS_COMBO);
            Controls.Add(label3);
            Controls.Add(Search_btn);
            Controls.Add(label2);
            Controls.Add(phone_number);
            Controls.Add(old_name);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Old_Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Old_Member";
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
        private System.Windows.Forms.Button Search_btn;
        private BindingSource bookBindingSource;
        private BindingSource bookBindingSource1;
        private Label label3;
        private ComboBox BOOKS_COMBO;
        private ComboBox DVD_COMBO;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label CHECKOUT;
        private Button button4;
        private Button button5;
        private TextBox Delete_Index;
        private Label label5;
        private Label Total_Check;
    }
}