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
            Book nBook = new Book(NBook_name.Text, NBook_author.Text, NBook_Year.Text, NBook_Price.Text);
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
    }
}
