using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Managment__System
{
    public partial class Login_form : Form
    {

        public Login_form()
        {
            InitializeComponent();

        }

        private void login_Click(object sender, EventArgs e)
        {/*
            if ((UserID_TB.Text == "231027188" && User_pass_TB.Text == "820366") ||
                (UserID_TB.Text == "231027652" && User_pass_TB.Text == "880711") ||
                (UserID_TB.Text == "231027807" && User_pass_TB.Text == "177882"))
            */{
                Form form = new Home_form();
                form.Show();
              }/*
            else { MessageBox.Show("Wrong username or Password"); }*/
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
