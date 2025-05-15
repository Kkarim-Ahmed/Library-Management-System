using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory;

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
            Book nBook = new Book(NBook_name.Text, NBook_author.Text, NBook_Year.Text, int.Parse(NBook_Price.Text), int.Parse(NBook_Quant.Text));
            Book.Add_Book_csv(nBook);
            MessageBox.Show("Done");
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = $"Memory Usage :{Sign_up.Mem().ToString()}";
        }

        private void NBook_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NBook_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void NBook_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NBook_Quant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NBook_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsAsciiDigit(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
            }
        }
    }
}
    