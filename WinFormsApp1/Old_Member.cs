using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Inventory;
using CSVClass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;


namespace Library_Managment__System
{
    public partial class Old_Member : Form
    {
        public static string name = "Unspecified", phone = "Unspecified", book_name = "Unspecified", book_author = "Unspecified", book_year = "Unspecified",
            book_price = "Unspecified", book_quant = "Unspecified";

        // Assuming this is a list of books. Replace with a list of members if necessary.
        public List<Book> Booklist = CsvFile<Book>.Read(Book.BOOK_Fpath,new Book.BookMap());

        public Old_Member()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            // Set ComboBox data source to the list of books (or members)
            comboBox1.DataSource = Booklist;
            comboBox1.DisplayMember = "Name"; // Display book names (or member names)
            comboBox1.ValueMember = "Name";   // Value stored when an item is selected (book name)

            // Enable AutoComplete for ComboBox
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;  // Suggest matching items as the user types
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems; // Use the list items as suggestions
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            name = old_name.Text;
            phone = phone_number.Text;

            // Assuming Book_Name is text input to search for a book by name
            int index = CsvFile<Book>.Search(Booklist, comboBox1.Text);

            if (index != null)
            {

                book_name = Booklist[index].Name;
                book_author = Booklist[index].Author;
                book_year = Booklist[index].Year;
                book_price = Booklist[index].price.ToString();
                book_quant = Booklist[index].quant.ToString();

                Check_out form = new Check_out();
                this.Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("The book does not exist.");
            }
        }

        private void Old_Member_Load(object sender, EventArgs e)
        {
            // Any initialization when the form loads
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle list box changes if needed
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle ComboBox selection change if necessary
            // For instance, show details based on selected book/member
            comboBox1.DisplayMember = "Name";
        }

        private void old_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
