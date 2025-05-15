namespace Library_Managment__System
{
    partial class ADD_BOOK
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
            label = new Label();
            NBook_name = new TextBox();
            NBook_author = new TextBox();
            NBook_Year = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NBook_Price = new TextBox();
            ADD_NBook = new Button();
            label4 = new Label();
            NBook_Quant = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(50, 49);
            label.Margin = new Padding(5, 0, 5, 0);
            label.Name = "label";
            label.Size = new Size(49, 20);
            label.TabIndex = 0;
            label.Text = "Name";
            // 
            // NBook_name
            // 
            NBook_name.Location = new Point(55, 100);
            NBook_name.Margin = new Padding(5, 4, 5, 4);
            NBook_name.Name = "NBook_name";
            NBook_name.Size = new Size(132, 27);
            NBook_name.TabIndex = 1;
            NBook_name.TextChanged += NBook_name_TextChanged;
            // 
            // NBook_author
            // 
            NBook_author.Location = new Point(55, 217);
            NBook_author.Margin = new Padding(5, 4, 5, 4);
            NBook_author.Name = "NBook_author";
            NBook_author.Size = new Size(132, 27);
            NBook_author.TabIndex = 2;
            // 
            // NBook_Year
            // 
            NBook_Year.Location = new Point(55, 329);
            NBook_Year.Margin = new Padding(5, 4, 5, 4);
            NBook_Year.Name = "NBook_Year";
            NBook_Year.Size = new Size(132, 27);
            NBook_Year.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 171);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 280);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 5;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 403);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // NBook_Price
            // 
            NBook_Price.Location = new Point(55, 459);
            NBook_Price.Margin = new Padding(5, 4, 5, 4);
            NBook_Price.Name = "NBook_Price";
            NBook_Price.Size = new Size(132, 27);
            NBook_Price.TabIndex = 7;
            NBook_Price.TextChanged += NBook_Price_TextChanged;
            NBook_Price.KeyPress += NBook_Price_KeyPress;
            // 
            // ADD_NBook
            // 
            ADD_NBook.Location = new Point(404, 264);
            ADD_NBook.Margin = new Padding(5, 4, 5, 4);
            ADD_NBook.Name = "ADD_NBook";
            ADD_NBook.Size = new Size(101, 36);
            ADD_NBook.TabIndex = 8;
            ADD_NBook.Text = "ADD";
            ADD_NBook.UseVisualStyleBackColor = true;
            ADD_NBook.Click += ADD_NBook_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 12);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 9;
            label4.Text = "Memory Usage";
            label4.Click += label4_Click;
            // 
            // NBook_Quant
            // 
            NBook_Quant.Location = new Point(380, 100);
            NBook_Quant.Name = "NBook_Quant";
            NBook_Quant.Size = new Size(125, 27);
            NBook_Quant.TabIndex = 10;
            NBook_Quant.KeyPress += NBook_Quant_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(368, 49);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 11;
            label5.Text = "Quantity";
            // 
            // ADD_BOOK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 617);
            Controls.Add(label5);
            Controls.Add(NBook_Quant);
            Controls.Add(label4);
            Controls.Add(ADD_NBook);
            Controls.Add(NBook_Price);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NBook_Year);
            Controls.Add(NBook_author);
            Controls.Add(NBook_name);
            Controls.Add(label);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ADD_BOOK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADD_BOOK";
            Load += ADD_BOOK_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox NBook_name;
        private System.Windows.Forms.TextBox NBook_author;
        private System.Windows.Forms.TextBox NBook_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NBook_Price;
        private System.Windows.Forms.Button ADD_NBook;
        private Label label4;
        private TextBox NBook_Quant;
        private Label label5;
    }
}