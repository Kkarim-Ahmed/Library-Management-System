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
    public partial class Old_Member : Form
    {
        public static string name = "Unspecified", phone = "Unspecified", book_name = "Unspecified", book_author = "Unspecified", book_year = "Unspecified",
            book_price = "Unspecified", book_quant = "Unspecified";
        public List<Book> Booklist = Book.Readbooks();
        public Old_Member()
        {
            InitializeComponent();

        }


        private void Search_btn_Click(object sender, EventArgs e)
        {
            name = old_name.Text;
            phone = phone_number.Text;
            Book found_book = Book.Search(Book_name.Text);
            if (found_book != null)
            {
                book_name = found_book.Name;
                book_author = found_book.Author;
                book_year = found_book.Year;
                book_price = found_book.price;
                book_quant = found_book.quant;



                Check_out form = new Check_out();
                this.Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("the book dosenot exist ");
            }
        }

        private void Old_Member_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}