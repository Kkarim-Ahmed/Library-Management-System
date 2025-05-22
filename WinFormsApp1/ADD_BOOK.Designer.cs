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
            components = new System.ComponentModel.Container();
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            quant_label = new Label();
            quant_Txtbox = new TextBox();
            NDvd_quant = new TextBox();
            label5 = new Label();
            NDvd_price = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            NDvd_year = new TextBox();
            NDvd_genre = new TextBox();
            NDvd_name = new TextBox();
            label9 = new Label();
            NDvd_durarion = new Label();
            NDvd_duration = new TextBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
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
            NBook_name.Location = new Point(50, 73);
            NBook_name.Margin = new Padding(5, 4, 5, 4);
            NBook_name.Name = "NBook_name";
            NBook_name.Size = new Size(132, 27);
            NBook_name.TabIndex = 1;
            NBook_name.KeyPress += NBook_name_KeyPress;
            // 
            // NBook_author
            // 
            NBook_author.Location = new Point(50, 168);
            NBook_author.Margin = new Padding(5, 4, 5, 4);
            NBook_author.MaxLength = 16;
            NBook_author.Name = "NBook_author";
            NBook_author.Size = new Size(132, 27);
            NBook_author.TabIndex = 2;
            // 
            // NBook_Year
            // 
            NBook_Year.Location = new Point(253, 73);
            NBook_Year.Margin = new Padding(5, 4, 5, 4);
            NBook_Year.MaxLength = 4;
            NBook_Year.Name = "NBook_Year";
            NBook_Year.Size = new Size(132, 27);
            NBook_Year.TabIndex = 3;
            NBook_Year.KeyPress += NBook_Year_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 124);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 49);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 5;
            label2.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 124);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // NBook_Price
            // 
            NBook_Price.Location = new Point(253, 168);
            NBook_Price.Margin = new Padding(3, 4, 3, 4);
            NBook_Price.Name = "NBook_Price";
            NBook_Price.Size = new Size(132, 27);
            NBook_Price.TabIndex = 12;
            NBook_Price.KeyPress += NBook_Price_KeyPress;
            // 
            // ADD_NBook
            // 
            ADD_NBook.Location = new Point(269, 256);
            ADD_NBook.Margin = new Padding(5, 4, 5, 4);
            ADD_NBook.Name = "ADD_NBook";
            ADD_NBook.Size = new Size(101, 36);
            ADD_NBook.TabIndex = 8;
            ADD_NBook.Text = "ADD_BOOK";
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
            // 
            // quant_label
            // 
            quant_label.AutoSize = true;
            quant_label.Location = new Point(471, 49);
            quant_label.Name = "quant_label";
            quant_label.Size = new Size(65, 20);
            quant_label.TabIndex = 10;
            quant_label.Text = "Quantity";
            // 
            // quant_Txtbox
            // 
            quant_Txtbox.Location = new Point(471, 73);
            quant_Txtbox.Margin = new Padding(3, 4, 3, 4);
            quant_Txtbox.MaxLength = 3;
            quant_Txtbox.Name = "quant_Txtbox";
            quant_Txtbox.Size = new Size(114, 27);
            quant_Txtbox.TabIndex = 11;
            quant_Txtbox.KeyPress += quant_Txtbox_KeyPress;
            // 
            // NDvd_quant
            // 
            NDvd_quant.Location = new Point(487, 439);
            NDvd_quant.Margin = new Padding(3, 4, 3, 4);
            NDvd_quant.MaxLength = 3;
            NDvd_quant.Name = "NDvd_quant";
            NDvd_quant.Size = new Size(132, 27);
            NDvd_quant.TabIndex = 22;
            NDvd_quant.KeyPress += NDvd_quant_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 415);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 21;
            label5.Text = "Quantity";
            // 
            // NDvd_price
            // 
            NDvd_price.Location = new Point(253, 439);
            NDvd_price.Margin = new Padding(3, 4, 3, 4);
            NDvd_price.MaxLength = 11;
            NDvd_price.Name = "NDvd_price";
            NDvd_price.Size = new Size(132, 27);
            NDvd_price.TabIndex = 23;
            NDvd_price.KeyPress += NDvd_price_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 415);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 19;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 415);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 18;
            label7.Text = "Year";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(253, 316);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 17;
            label8.Text = "Genre";
            // 
            // NDvd_year
            // 
            NDvd_year.Location = new Point(50, 439);
            NDvd_year.Margin = new Padding(5, 4, 5, 4);
            NDvd_year.MaxLength = 4;
            NDvd_year.Name = "NDvd_year";
            NDvd_year.Size = new Size(132, 27);
            NDvd_year.TabIndex = 16;
            NDvd_year.KeyPress += NDvd_year_KeyPress;
            // 
            // NDvd_genre
            // 
            NDvd_genre.Location = new Point(253, 340);
            NDvd_genre.Margin = new Padding(5, 4, 5, 4);
            NDvd_genre.Name = "NDvd_genre";
            NDvd_genre.Size = new Size(132, 27);
            NDvd_genre.TabIndex = 15;
            // 
            // NDvd_name
            // 
            NDvd_name.Location = new Point(50, 340);
            NDvd_name.Margin = new Padding(5, 4, 5, 4);
            NDvd_name.MaxLength = 16;
            NDvd_name.Name = "NDvd_name";
            NDvd_name.Size = new Size(132, 27);
            NDvd_name.TabIndex = 14;
            NDvd_name.KeyPress += NDvd_name_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 316);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 13;
            label9.Text = "Name";
            // 
            // NDvd_durarion
            // 
            NDvd_durarion.AutoSize = true;
            NDvd_durarion.Location = new Point(505, 316);
            NDvd_durarion.Margin = new Padding(5, 0, 5, 0);
            NDvd_durarion.Name = "NDvd_durarion";
            NDvd_durarion.Size = new Size(67, 20);
            NDvd_durarion.TabIndex = 25;
            NDvd_durarion.Text = "Duration";
            // 
            // NDvd_duration
            // 
            NDvd_duration.Location = new Point(487, 340);
            NDvd_duration.Margin = new Padding(5, 4, 5, 4);
            NDvd_duration.MaxLength = 5;
            NDvd_duration.Name = "NDvd_duration";
            NDvd_duration.Size = new Size(132, 27);
            NDvd_duration.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(269, 520);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 36);
            button1.TabIndex = 26;
            button1.Text = "ADD_DVD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // ADD_BOOK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 617);
            Controls.Add(button1);
            Controls.Add(NDvd_durarion);
            Controls.Add(NDvd_duration);
            Controls.Add(NDvd_quant);
            Controls.Add(label5);
            Controls.Add(NDvd_price);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(NDvd_year);
            Controls.Add(NDvd_genre);
            Controls.Add(NDvd_name);
            Controls.Add(label9);
            Controls.Add(quant_Txtbox);
            Controls.Add(quant_label);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label quant_label;
        private TextBox quant_Txtbox;
        private TextBox NDvd_quant;
        private Label label5;
        private TextBox NDvd_price;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox NDvd_year;
        private TextBox NDvd_genre;
        private TextBox NDvd_name;
        private Label label9;
        private Label NDvd_durarion;
        private TextBox NDvd_duration;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}