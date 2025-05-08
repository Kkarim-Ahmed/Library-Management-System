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
    public partial class Check_out : Form
    {
        public Check_out()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = $"Name : {Old_Member.name}\n";
            label1.Text += $"ID :{Old_Member.phone} \n";
            label1.Text += $"trust score : 100%\n";
            label1.Text += $"Book_name : {Old_Member.book_name}\n";
            label1.Text += $"Book_Author : {Old_Member.book_author}\n";
            label1.Text += $"Year : {Old_Member.book_year}\n";
            label1.Text += $"Book_Price : {Old_Member.book_price}\n";
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Close();
  
        }
    }
}
