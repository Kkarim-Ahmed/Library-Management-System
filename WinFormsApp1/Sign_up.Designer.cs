using Inventory;
namespace Library_Managment__System
{
    partial class Sign_up
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
            NMember_name = new TextBox();
            label2 = new Label();
            NMemebr_phone = new TextBox();
            NMember_depart = new TextBox();
            label3 = new Label();
            ADD_NMember = new Button();
            bookBindingSource = new BindingSource(components);
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "User Name:";
            // 
            // NMember_name
            // 
            NMember_name.Location = new Point(43, 67);
            NMember_name.Margin = new Padding(4, 3, 4, 3);
            NMember_name.Name = "NMember_name";
            NMember_name.Size = new Size(116, 23);
            NMember_name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            // 
            // NMemebr_phone
            // 
            NMemebr_phone.Location = new Point(43, 166);
            NMemebr_phone.Margin = new Padding(4, 3, 4, 3);
            NMemebr_phone.Name = "NMemebr_phone";
            NMemebr_phone.Size = new Size(116, 23);
            NMemebr_phone.TabIndex = 3;
            // 
            // NMember_depart
            // 
            NMember_depart.Location = new Point(43, 262);
            NMember_depart.Margin = new Padding(4, 3, 4, 3);
            NMember_depart.Name = "NMember_depart";
            NMember_depart.Size = new Size(116, 23);
            NMember_depart.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 223);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Department";
            // 
            // ADD_NMember
            // 
            ADD_NMember.Location = new Point(322, 166);
            ADD_NMember.Margin = new Padding(4, 3, 4, 3);
            ADD_NMember.Name = "ADD_NMember";
            ADD_NMember.Size = new Size(88, 27);
            ADD_NMember.TabIndex = 6;
            ADD_NMember.Text = "ADD";
            ADD_NMember.UseVisualStyleBackColor = true;
            ADD_NMember.Click += ADD_NMember_Click;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 21);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 8;
            label4.Text = " Memory Usage";
            label4.Click += label4_Click;
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 463);
            Controls.Add(label4);
            Controls.Add(ADD_NMember);
            Controls.Add(label3);
            Controls.Add(NMember_depart);
            Controls.Add(NMemebr_phone);
            Controls.Add(label2);
            Controls.Add(NMember_name);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Sign_up";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign_up";
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NMember_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NMemebr_phone;
        private System.Windows.Forms.TextBox NMember_depart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ADD_NMember;
        private BindingSource bookBindingSource;
        public Label label4;
    }
}