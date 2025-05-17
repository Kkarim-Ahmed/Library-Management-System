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
            label2 = new Label();
            SuspendLayout();
            // 
            // Borrow_btn
            // 
            Borrow_btn.BackColor = Color.Transparent;
            Borrow_btn.FlatStyle = FlatStyle.Flat;
            Borrow_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Borrow_btn.ForeColor = SystemColors.ButtonHighlight;
            Borrow_btn.Location = new Point(85, 77);
            Borrow_btn.Margin = new Padding(4, 3, 4, 3);
            Borrow_btn.Name = "Borrow_btn";
            Borrow_btn.Size = new Size(88, 27);
            Borrow_btn.TabIndex = 0;
            Borrow_btn.Text = "Borrow";
            Borrow_btn.UseVisualStyleBackColor = false;
            Borrow_btn.Click += Borrow_btn_Click;
            // 
            // Return_btn
            // 
            Return_btn.BackColor = Color.Transparent;
            Return_btn.FlatStyle = FlatStyle.Flat;
            Return_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Return_btn.ForeColor = SystemColors.ButtonHighlight;
            Return_btn.Location = new Point(271, 77);
            Return_btn.Margin = new Padding(4, 3, 4, 3);
            Return_btn.Name = "Return_btn";
            Return_btn.Size = new Size(88, 27);
            Return_btn.TabIndex = 1;
            Return_btn.Text = "Return";
            Return_btn.UseVisualStyleBackColor = false;
            Return_btn.Click += Return_btn_Click;
            // 
            // Buy_btn
            // 
            Buy_btn.BackColor = Color.Transparent;
            Buy_btn.FlatStyle = FlatStyle.Flat;
            Buy_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buy_btn.ForeColor = SystemColors.ButtonHighlight;
            Buy_btn.Location = new Point(457, 77);
            Buy_btn.Margin = new Padding(4, 3, 4, 3);
            Buy_btn.Name = "Buy_btn";
            Buy_btn.Size = new Size(88, 27);
            Buy_btn.TabIndex = 2;
            Buy_btn.Text = "Buy";
            Buy_btn.UseVisualStyleBackColor = false;
            Buy_btn.Click += Buy_btn_Click;
            // 
            // Add_book_btn
            // 
            Add_book_btn.BackColor = Color.Transparent;
            Add_book_btn.FlatStyle = FlatStyle.Flat;
            Add_book_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_book_btn.ForeColor = SystemColors.ButtonHighlight;
            Add_book_btn.Location = new Point(176, 224);
            Add_book_btn.Margin = new Padding(4, 3, 4, 3);
            Add_book_btn.Name = "Add_book_btn";
            Add_book_btn.Size = new Size(88, 27);
            Add_book_btn.TabIndex = 3;
            Add_book_btn.Text = "Add_item";
            Add_book_btn.UseVisualStyleBackColor = false;
            Add_book_btn.Click += button4_Click;
            // 
            // New_member_btn
            // 
            New_member_btn.BackColor = Color.Transparent;
            New_member_btn.FlatStyle = FlatStyle.Flat;
            New_member_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            New_member_btn.ForeColor = SystemColors.ButtonHighlight;
            New_member_btn.Location = new Point(358, 224);
            New_member_btn.Margin = new Padding(4, 3, 4, 3);
            New_member_btn.Name = "New_member_btn";
            New_member_btn.Size = new Size(124, 27);
            New_member_btn.TabIndex = 4;
            New_member_btn.Text = "New_member";
            New_member_btn.UseVisualStyleBackColor = false;
            New_member_btn.Click += New_member_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 5;
            label1.Text = "Memory Usage:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Red;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(571, 20);
            label2.Name = "label2";
            label2.Size = new Size(30, 17);
            label2.TabIndex = 6;
            label2.Text = "   X";
            label2.Click += label2_Click;
            // 
            // Home_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(623, 463);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(New_member_btn);
            Controls.Add(Add_book_btn);
            Controls.Add(Buy_btn);
            Controls.Add(Return_btn);
            Controls.Add(Borrow_btn);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Home_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home_form";
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
        private Label label2;
    }
}