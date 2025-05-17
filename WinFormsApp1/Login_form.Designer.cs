namespace Library_Managment__System
{
    partial class Login_form
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
            Login = new Button();
            label2 = new Label();
            UserID_TB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            User_pass_TB = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = Color.DarkOliveGreen;
            Login.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.Location = new Point(455, 241);
            Login.Margin = new Padding(4, 3, 4, 3);
            Login.Name = "Login";
            Login.Size = new Size(118, 40);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += login_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.LawnGreen;
            label2.Image = WinFormsApp1.Properties.Resources.WhatsApp_Image_2025_05_15_at_01_50_12_c662af82;
            label2.Location = new Point(-5, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(397, 473);
            label2.TabIndex = 3;
            // 
            // UserID_TB
            // 
            UserID_TB.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserID_TB.Location = new Point(457, 110);
            UserID_TB.Margin = new Padding(4, 3, 4, 3);
            UserID_TB.Name = "UserID_TB";
            UserID_TB.Size = new Size(116, 21);
            UserID_TB.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(474, 75);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 4;
            label3.Text = "User ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(457, 153);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // User_pass_TB
            // 
            User_pass_TB.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User_pass_TB.Location = new Point(455, 186);
            User_pass_TB.Margin = new Padding(4, 3, 4, 3);
            User_pass_TB.Name = "User_pass_TB";
            User_pass_TB.Size = new Size(118, 21);
            User_pass_TB.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(585, 9);
            label1.Name = "label1";
            label1.Size = new Size(26, 17);
            label1.TabIndex = 7;
            label1.Text = "  X";
            label1.Click += label1_Click;
            // 
            // Login_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 463);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(UserID_TB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(User_pass_TB);
            Controls.Add(Login);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_form";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserID_TB;
        private System.Windows.Forms.Label label3;
        private Label label4;
        private TextBox User_pass_TB;
        private Label label1;
    }
}

