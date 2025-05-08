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
            listBox1.Visible = false;
            listBox1.SelectedIndexChanged += new System.EventHandler(listBox1_SelectedIndexChanged);

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

        private void nameTextBox(object sender, EventArgs e)
        {
            var query = Book_name.Text.ToLower(); // Get the text typed by the user and convert it to lowercase

            // Filter suggestions based on the query typed by the user
            var suggestions = Booklist
                .Where(book => book.Name.ToLower().Contains(query))  // Find books that match the query
                .Take(5)  // Limit to 5 suggestions
                .ToList();

            // Show the suggestion list only if there are matches and the query is not empty
            if (string.IsNullOrWhiteSpace(query) || !suggestions.Any())
            {
                listBox1.Visible = false; // Hide suggestions if input is empty or no matches
            }
            else
            {
                listBox1.DataSource = suggestions; // Populate the ListBox with the filtered suggestions
                listBox1.Visible = true; // Make the suggestion list visible
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = Book_name.Text.ToLower(); // Get the text typed by the user and convert it to lowercase

            // Filter suggestions based on the query typed by the user
            var suggestions = Booklist
                .Where(book => book.Name.ToLower().Contains(query))  // Find books that match the query
                .Take(5)  // Limit to 5 suggestions
                .ToList();

            // Show the suggestion list only if there are matches and the query is not empty
            if (string.IsNullOrWhiteSpace(query) || !suggestions.Any())
            {
                listBox1.Visible = false; // Hide suggestions if input is empty or no matches
            }
            else
            {
                listBox1.DataSource = suggestions.Select(b => b.Name).ToList(); // Populate the ListBox with the filtered suggestions (only book names)
                listBox1.Visible = true; // Make the suggestion list visible
            }

        }
    }
}