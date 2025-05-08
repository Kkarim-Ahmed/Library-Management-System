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
        {
           // if (textBox1.Text == "820366" && UserID_TB.Text == "231027188") ;
            {
               // MessageBox.Show("Wellcome ENG : Farah ");
                Home_form form = new Home_form();
                form.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
