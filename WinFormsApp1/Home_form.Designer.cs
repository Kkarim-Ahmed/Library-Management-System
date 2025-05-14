namespace Library_Managment__System
{
    partial class Home_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_form));
            Borrow_btn = new Button();
            Return_btn = new Button();
            Buy_btn = new Button();
            Add_book_btn = new Button();
            New_member_btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Borrow_btn
            // 
            Borrow_btn.BackColor = SystemColors.Control;
            Borrow_btn.Location = new Point(97, 103);
            Borrow_btn.Margin = new Padding(5, 4, 5, 4);
            Borrow_btn.Name = "Borrow_btn";
            Borrow_btn.Size = new Size(101, 36);
            Borrow_btn.TabIndex = 0;
            Borrow_btn.Text = "Borrow";
            Borrow_btn.UseVisualStyleBackColor = false;
            Borrow_btn.Click += Borrow_btn_Click;
            // 
            // Return_btn
            // 
            Return_btn.Location = new Point(310, 103);
            Return_btn.Margin = new Padding(5, 4, 5, 4);
            Return_btn.Name = "Return_btn";
            Return_btn.Size = new Size(101, 36);
            Return_btn.TabIndex = 1;
            Return_btn.Text = "Return";
            Return_btn.UseVisualStyleBackColor = true;
            Return_btn.Click += Return_btn_Click;
            // 
            // Buy_btn
            // 
            Buy_btn.Location = new Point(522, 103);
            Buy_btn.Margin = new Padding(5, 4, 5, 4);
            Buy_btn.Name = "Buy_btn";
            Buy_btn.Size = new Size(101, 36);
            Buy_btn.TabIndex = 2;
            Buy_btn.Text = "Buy";
            Buy_btn.UseVisualStyleBackColor = true;
            Buy_btn.Click += Buy_btn_Click;
            // 
            // Add_book_btn
            // 
            Add_book_btn.Location = new Point(201, 299);
            Add_book_btn.Margin = new Padding(5, 4, 5, 4);
            Add_book_btn.Name = "Add_book_btn";
            Add_book_btn.Size = new Size(101, 36);
            Add_book_btn.TabIndex = 3;
            Add_book_btn.Text = "Add_Book";
            Add_book_btn.UseVisualStyleBackColor = true;
            Add_book_btn.Click += button4_Click;
            // 
            // New_member_btn
            // 
            New_member_btn.Location = new Point(409, 299);
            New_member_btn.Margin = new Padding(5, 4, 5, 4);
            New_member_btn.Name = "New_member_btn";
            New_member_btn.Size = new Size(142, 36);
            New_member_btn.TabIndex = 4;
            New_member_btn.Text = "New_member";
            New_member_btn.UseVisualStyleBackColor = true;
            New_member_btn.Click += New_member_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 21);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 5;
            label1.Text = "Memory Usage:";
            label1.Click += label1_Click;
            // 
            // Home_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(712, 617);
            Controls.Add(label1);
            Controls.Add(New_member_btn);
            Controls.Add(Add_book_btn);
            Controls.Add(Buy_btn);
            Controls.Add(Return_btn);
            Controls.Add(Borrow_btn);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Home_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home_form";
            Load += Home_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Borrow_btn;
        private System.Windows.Forms.Button Return_btn;
        private System.Windows.Forms.Button Buy_btn;
        private System.Windows.Forms.Button Add_book_btn;
        private System.Windows.Forms.Button New_member_btn;
        private Label label1;
    }
}