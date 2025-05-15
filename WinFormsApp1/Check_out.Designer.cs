namespace Library_Managment__System
{
    partial class Check_out
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
            label1 = new Label();
            Done = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.MinimumSize = new Size(200, 231);
            label1.Name = "label1";
            label1.Size = new Size(200, 231);
            label1.TabIndex = 0;
            label1.Text = "Bill";
            label1.Click += label1_Click;
            // 
            // Done
            // 
            Done.Location = new Point(21, 388);
            Done.Margin = new Padding(4, 5, 4, 5);
            Done.Name = "Done";
            Done.Size = new Size(100, 35);
            Done.TabIndex = 1;
            Done.Text = "Done";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // Check_out
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 617);
            Controls.Add(Done);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Check_out";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check_out";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Done;
    }
}