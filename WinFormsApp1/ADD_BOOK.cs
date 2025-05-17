//using CSVClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Inventory;

namespace Library_Managment__System
{
    public partial class ADD_BOOK : Form
    {
        public ADD_BOOK()
        {
            InitializeComponent();
        }

        private void ADD_BOOK_Load(object sender, EventArgs e)
        {

        }

        private void ADD_NBook_Click(object sender, EventArgs e)
        {
            Book elemnt = new Book(NBook_name.Text, NBook_author.Text, NBook_Year.Text, int.Parse(NBook_Price.Text), int.Parse(quant_Txtbox.Text));
            Inventory.AddItem(elemnt);
        }

        private void NBook_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NBook_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void quant_Txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = $"Memory Usage :{(int)(Sign_up.Mem() / 1024) + "MB"}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DVD element = new DVD(NDvd_name.Text, NDvd_genre.Text, NDvd_duration.Text, int.Parse(NDvd_price.Text), int.Parse(NDvd_quant.Text),NDvd_year.Text);
            Inventory.AddItem(element);
        }
    }
}
