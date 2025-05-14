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
            label2 = new Label();
            label3 = new Label();
            Search_btn = new Button();
            bookBindingSource = new BindingSource(components);
            comboBox1 = new ComboBox();
            userBindingSource1 = new BindingSource(components);
            bookBindingSource1 = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 57);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // old_name
            // 
            old_name.AllowDrop = true;
            old_name.BackColor = SystemColors.Window;
            old_name.ForeColor = SystemColors.Menu;
            old_name.Location = new Point(21, 97);
            old_name.Margin = new Padding(5, 4, 5, 4);
            old_name.Name = "old_name";
            old_name.Size = new Size(132, 27);
            old_name.TabIndex = 1;
            // 
            // phone_number
            // 
            phone_number.Location = new Point(21, 203);
            phone_number.Margin = new Padding(5, 4, 5, 4);
            phone_number.Name = "phone_number";
            phone_number.Size = new Size(132, 27);
            phone_number.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 173);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 4;
            label2.Text = "phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 317);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "Book_name";
            // 
            // Search_btn
            // 
            Search_btn.Location = new Point(395, 231);
            Search_btn.Margin = new Padding(5, 4, 5, 4);
            Search_btn.Name = "Search_btn";
            Search_btn.Size = new Size(101, 36);
            Search_btn.TabIndex = 6;
            Search_btn.Text = "Search";
            Search_btn.UseVisualStyleBackColor = true;
            Search_btn.Click += Search_btn_Click;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // comboBox1
            // 
            comboBox1.DataSource = userBindingSource1;
            comboBox1.DisplayMember = "Name";
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 363);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 28);
            comboBox1.TabIndex = 7;
            comboBox1.ValueMember = "Name";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // userBindingSource1
            // 
            userBindingSource1.DataSource = typeof(User);
            // 
            // bookBindingSource1
            // 
            bookBindingSource1.DataSource = typeof(Book);
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // Old_Member
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 617);
            Controls.Add(comboBox1);
            Controls.Add(Search_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(phone_number);
            Controls.Add(old_name);
            Controls.Add(label1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Old_Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Old_Member";
            Load += Old_Member_Load;
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox old_name;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Search_btn;
        private BindingSource bookBindingSource;
        private ComboBox comboBox1;
        private BindingSource bookBindingSource1;
        private BindingSource userBindingSource;
        private BindingSource userBindingSource1;
    }
}