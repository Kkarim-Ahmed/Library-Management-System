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
            label1.Text = "ali";
            label1.Text = "moahemd";
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Close();
  
        }
    }
}
