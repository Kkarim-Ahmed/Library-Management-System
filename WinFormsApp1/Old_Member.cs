using CsvHelper.Configuration.Attributes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Pipelines;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Library_Managment__System
{
    public partial class Old_Member : Form
    {
        public static double Total; //for the checkout label 
        public static int I; //  couneter for checkout label 

        List<Objects> Checkout_list = new List<Objects>();// Buy List
        List<Borrow> Checkout_borrowlist = new List<Borrow>();//Borrow , return  list

        public Old_Member()
        {
            I = 1; // reintializing the counter  
            Total = 0;//reintializing the Counter Label  
            InitializeComponent();
            // suggesting and appending for BOOK_combo box 
            BOOKS_COMBO.DataSource = Book.books;
            BOOKS_COMBO.DisplayMember = "Name";
            BOOKS_COMBO.ValueMember = "Name";
            BOOKS_COMBO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            BOOKS_COMBO.AutoCompleteSource = AutoCompleteSource.ListItems;
            BOOKS_COMBO.DropDownStyle = ComboBoxStyle.DropDown;
            BOOKS_COMBO.Hide();
            // suggesting and appending for DVD_Combo_box 
            DVD_COMBO.DataSource = DVD.DVDS;
            DVD_COMBO.DisplayMember = "Name";
            DVD_COMBO.ValueMember = "Name";
            DVD_COMBO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DVD_COMBO.AutoCompleteSource = AutoCompleteSource.ListItems;
            DVD_COMBO.DropDownStyle = ComboBoxStyle.DropDown;
            DVD_COMBO.Hide();
            // hiding buttons until we find the user in the CSV file.
            button2.Hide();
            button3.Hide();
            label3.Hide();
            label4.Hide();
            Total_Check.Hide();
            Delete_Label.Hide();
            Delete_Label.Hide();
        }
        private void phone_number_KeyPress(object sender, KeyPressEventArgs e)// Data validation to type only digits in phone number
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)//button search name and phone 
        {
            Delete_Label.Hide(); //To hide unnecessary label if present
            int index = CsvFile<Members>.Search(Members.Memberlist, old_name.Text);// searching in the CSV File (function in methods class)
            if (index == -1)//Not found in the CSV File
            {
                Search_label.ForeColor = Color.Red;
                Search_label.Text = "Check member credentials.";
            }
            else if (Members.Memberlist[index].PhoneNumber == phone_number.Text)
            {
                // Showing Buttons Add Book and DVD And Combo boxes
                Search_label.ForeColor = Color.Green;
                Search_label.Text = "Member verified.";
                button2.Show();
                button3.Show();
                label3.Show();
                label4.Show();
                phone_number.Enabled = false;
                old_name.Enabled = false;
                BOOKS_COMBO.Show();
                DVD_COMBO.Show();
            }
            else// Name found but wrong phone number
            {
                Search_label.ForeColor = Color.Red;
                Search_label.Text = "Wrong phone number. Please check.";
            }
        }
        private void button2_Click(object sender, EventArgs e)//ADD BOOK BUTTON
        {
            Delete_Label.Hide(); //To hide unnecessary label if present
            int index = CsvFile<Book>.Search(Book.books, BOOKS_COMBO.Text);//Searching in the Books Csv
            if (index == -1)// Checks if book exists
            {
                SearchBooks_label.ForeColor = Color.Red;
                SearchBooks_label.Text = "Book not found.";
                return;
            }
            if (Home_form.key == 0) //BUY Button
            {
                int count = Checkout_list.Count(i => i.Name == BOOKS_COMBO.Text); // number of times the book was added to checkout
                if (Book.books[index].quant <= count)
                {
                    SearchBooks_label.ForeColor = Color.Red;
                    SearchBooks_label.Text = "Book not available.";
                }
                else
                {
                    Checkout_list.Add(Book.books[index]);//Adding to Checkout List
                    Total += Book.books[index].price;//updating Total price
                    // updating GUI
                    CHECKOUT.Items.Add($"({I}) Book: {Book.books[index].Name} - ${Book.books[index].price}");
                    Total_Check.Text = $"Total: ${Total}";
                    Total_Check.Show();
                    SearchBooks_label.ForeColor = Color.Green;
                    SearchBooks_label.Text = "Book added to checkout.";
                    I++;
                }
            }
            else if (Home_form.key == 1)// Return Form
            {
                bool found = false;
                var list = Borrow.FindBorrowed(old_name.Text.ToLower());//all borrowed books by the user 
                int donebefore = Checkout_borrowlist.FindIndex(i => !string.IsNullOrEmpty(i.Itemname)
                    && i.Itemname.ToLower().Equals(BOOKS_COMBO.Text.ToLower(),
                    StringComparison.OrdinalIgnoreCase)); // variable to check if book was added to borrow list
                foreach (var item in list)//loop in the list
                {
                    //check if the book found in the list 
                    if (donebefore != -1) // check if book was already added
                    {
                        SearchBooks_label.Text = "This book is already in the checkout list.";
                        SearchBooks_label.ForeColor = Color.Red;
                        SearchBooks_label.Show();
                        found = true;
                        break; //break the Foreach if Found 
                    }
                    if (item.Itemname.ToLower() == BOOKS_COMBO.Text.ToLower()
                            && item.Itemtype.ToLower() == "book")//Comparison
                    {
                        found = true;
                        Checkout_borrowlist.Add(item); //add borrow list
                        if (Checkout_borrowlist[I - 1].Duedate == DateTime.Now.ToString())
                            Total += Checkout_borrowlist[I - 1].price * 0.1; //check for due date
                        CHECKOUT.Items.Add($"({I}) Book: {Book.books[index].Name} - ${Book.books[index].price}"); //updating GUI     
                        Total_Check.Text = $"Returning {I} item(s)";
                        Total_Check.Show();
                        SearchBooks_label.ForeColor = Color.Green;
                        SearchBooks_label.Text = "Book added to checkout.";
                        I++;
                        break;
                    }
                }
                if (!found) //Updating GUI IF the user did not borrow the book
                {
                    SearchBooks_label.ForeColor = Color.Red;
                    SearchBooks_label.Text = "You have not borrowed this book.";
                }
            }
            else if (Home_form.key == 2)//Borrow FORM
            {
                var list = Borrow.FindBorrowed(old_name.Text.ToLower());//all borrowed books by the user
                int Taken = list.FindIndex(i => !string.IsNullOrEmpty(i.Itemname) &&
                i.Itemname.ToLower().Equals(BOOKS_COMBO.Text.ToLower(),
                    StringComparison.OrdinalIgnoreCase)); // checks if user already borrowed this book

                if (Taken == -1)// if book isn't borrowed
                {
                    int donebefore = Checkout_borrowlist.FindIndex(i => !string.IsNullOrEmpty(i.Itemname)
                            && i.Itemname.ToLower().Equals(BOOKS_COMBO.Text.ToLower(),
                            StringComparison.OrdinalIgnoreCase)); // checks if book was already in checkout list
                    if (donebefore != -1)
                    {
                        SearchBooks_label.Text = "This book is already in the checkout list.";
                        SearchBooks_label.ForeColor = Color.Red;
                        SearchBooks_label.Show();
                    }
                    else // i book wasnt added
                    {
                        int count_1 = Checkout_borrowlist.Count(i => i.Itemname == BOOKS_COMBO.Text); // number if times the book was added to checkout
                        if (Book.books[index].quant <= count_1)//if the book is not available
                        {
                            SearchBooks_label.ForeColor = Color.Red;
                            SearchBooks_label.Text = "Book not available.";
                        }
                        else
                        {
                            Checkout_borrowlist.Add(new Borrow(old_name.Text.ToLower(), Book.books[index].Name, "Book", DateAndTime.Now.AddDays(14).ToString())); //adding to checkout_borrow list.
                            CHECKOUT.Items.Add($"({I}) Book: {Book.books[index].Name} - ${Book.books[index].price}"); //updating to the GUI
                            Total_Check.Show();
                            Total_Check.Text = $"Borrowing {I} item(s)";
                            SearchBooks_label.ForeColor = Color.Green;
                            SearchBooks_label.Text = "Book added to checkout.";
                            I++;
                        }
                    }
                }
                else // if Item was found in borrowed list
                {
                    SearchBooks_label.ForeColor = Color.Red;
                    SearchBooks_label.Text = "This book was already borrowed.";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)//ADD DVD BUTTON
        {
            Delete_Label.Hide(); //To hide unnecessary label if present
            int index = CsvFile<DVD>.Search(DVD.DVDS, DVD_COMBO.Text); // serching the DVD in the DVD file
            if (index == -1) // break from the Function if the Book Not Found 
            {
                SearchDVD_label.ForeColor = Color.Red;
                SearchDVD_label.Text = "DVD not found.";
                return;
            }
            if (Home_form.key == 0)//BUY FORM
            {
                if (DVD.DVDS[index].quant <= 0)//if the DVD is not available
                {
                    SearchDVD_label.ForeColor = Color.Red;
                    SearchDVD_label.Text = "DVD not available.";
                }
                else
                {
                    int count = Checkout_list.Count(i => i.Name == DVD_COMBO.Text); // number if times the DVD was added to checkout
                    if (DVD.DVDS[index].quant <= count)//if the DVD is not available
                    {
                        SearchDVD_label.ForeColor = Color.Red;
                        SearchDVD_label.Text = "DVD not available.";
                        return;
                    }
                    else
                    {
                        Checkout_list.Add(DVD.DVDS[index]); //Addind to Checkout list
                        CHECKOUT.Items.Add($"({I}) DVD: {DVD.DVDS[index].Name} - ${DVD.DVDS[index].price}"); //Updating the GUI
                        Total_Check.Show();
                        Total += DVD.DVDS[index].price;
                        Total_Check.Text = $"Total: ${Total}";
                        SearchDVD_label.ForeColor = Color.Green;
                        SearchDVD_label.Text = "DVD added to checkout.";
                        I++;
                    }
                }
            }
            else if (Home_form.key == 1)//Return Form
            {
                bool found = false;
                int donebefore = Checkout_borrowlist.FindIndex(i => !string.IsNullOrEmpty(i.Itemname)
                    && i.Itemname.ToLower().Equals(DVD_COMBO.Text.ToLower(),
                    StringComparison.OrdinalIgnoreCase));
                var list = Borrow.FindBorrowed(old_name.Text.ToLower()); //storing the Borrowed list in a list
                foreach (var item in list)
                {
                    if (donebefore != -1)
                    {
                        SearchDVD_label.Text = "This DVD is already in the checkout list.";
                        SearchDVD_label.ForeColor = Color.Red;
                        SearchDVD_label.Show();
                        found = true;
                        break;
                    }
                    if (item.Itemname.ToLower() == DVD_COMBO.Text.ToLower() && item.Itemtype.ToLower() == "dvd")
                    {
                        found = true;
                        Checkout_borrowlist.Add(item); //Adding DVD to the CheckoutList
                        if (Checkout_borrowlist[I - 1].Duedate == DateTime.Now.ToString())
                            Total += Checkout_borrowlist[I - 1].price * 0.1;
                        SearchDVD_label.ForeColor = Color.Green;
                        SearchDVD_label.Text = "DVD added to checkout.";
                        CHECKOUT.Items.Add($"({I}) DVD: {DVD.DVDS[index].Name} - ${DVD.DVDS[index].price}"); //Updating The GUI
                        Total_Check.Show();
                        Total_Check.Text = $"Returning {I} item(s)";
                        I++;
                        break;
                    }
                }
                if (!found) //Updating GUI IF the user did not borrow the book
                {
                    SearchDVD_label.ForeColor = Color.Red;
                    SearchDVD_label.Text = "You have not borrowed this DVD.";
                }
            }
            else if (Home_form.key == 2)//BORROW form
            {
                var list = Borrow.FindBorrowed(old_name.Text.ToLower());//all borrowed Items by the user
                int Taken = list.FindIndex(i => !string.IsNullOrEmpty(i.Itemname) &&
                   i.Itemname.ToLower().Equals(DVD_COMBO.Text.ToLower(),
                       StringComparison.OrdinalIgnoreCase)); // checks if user already borrowed this DVD

                if (Taken == -1) // if DVD isn't borrowed
                {
                    int donebefore = Checkout_borrowlist.FindIndex(i => !string.IsNullOrEmpty(i.Itemname)
                            && i.Itemname.ToLower().Equals(DVD_COMBO.Text.ToLower(),
                            StringComparison.OrdinalIgnoreCase)); // checks if DVD was already in checkout list
                    if (donebefore != -1)
                    {
                        SearchDVD_label.Text = "This DVD is already in the checkout list.";
                        SearchDVD_label.ForeColor = Color.Red;
                        SearchDVD_label.Show();
                    }
                    else // i DVD wasnt added
                    {
                        int count = Checkout_borrowlist.Count(i => i.Itemname == DVD_COMBO.Text); // number if times the DVD was added to checkout
                        if (DVD.DVDS[index].quant >= count)//if the DVD is not available
                        {
                            SearchDVD_label.ForeColor = Color.Red;
                            SearchDVD_label.Text = "DVD not available.";
                            return;
                        }
                        else
                        {
                            Checkout_borrowlist.Add(new Borrow(old_name.Text.ToLower(), DVD.DVDS[index].Name, "DVD", DateAndTime.DateString)); //adding to checkout_borrow list.
                            SearchDVD_label.ForeColor = Color.Green;
                            SearchDVD_label.Text = "DVD added to checkout.";
                            CHECKOUT.Items.Add($"({I}) DVD: {DVD.DVDS[index].Name} - ${DVD.DVDS[index].price}"); //updating to the GUI
                            Total_Check.Show();
                            Total_Check.Text = $"Borrowing {I} item(s)";
                            I++;
                        }
                    }
                }
                else // if Item was found in borrowed list
                {
                    SearchDVD_label.ForeColor = Color.Red;
                    SearchDVD_label.Text = "This DVD was already borrowed.";
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)//DELETE BUTTON
        {
            Delete_Label.Hide(); //To hide unnecessary label if present
            int ind = -1;

            try
            {
                ind = int.Parse(Delete_Index.Text);
            }
            catch (Exception)
            {
                Delete_Label.Text = "Invalid index format.";
                Delete_Label.Show();
                return;
            }

            // The ListBox is 0-based, but user input is likely 1-based
            int listIndex = ind - 1;

            if (Home_form.key == 0) // BUY FORM
            {
                if (listIndex < 0 || listIndex >= Checkout_list.Count)
                {
                    Delete_Label.Show();
                    Delete_Label.ForeColor = Color.Red;
                    Delete_Label.Text = "Index out of range.";
                    return;
                }

                // Remove from internal list and ListBox
                var removed = Checkout_list[listIndex];
                Total -= removed is Book book ? book.price : (removed is DVD dvd ? dvd.price : 0);
                Checkout_list.RemoveAt(listIndex);
                CHECKOUT.Items.RemoveAt(listIndex);

                // Rebuild the ListBox with correct numbering
                CHECKOUT.Items.Clear();
                I = 1;
                foreach (var item in Checkout_list)
                {
                    if (item is Book b)
                        CHECKOUT.Items.Add($"({I}) Book: {b.Name} - ${b.price}");
                    else if (item is DVD d)
                        CHECKOUT.Items.Add($"({I}) DVD: {d.Name} - ${d.price}");
                    I++;
                }
                Total_Check.Text = $"Total: ${Total}";
                Total_Check.Show();
            }
            else // RETURN or BORROW FORM
            {
                if (listIndex < 0 || listIndex >= Checkout_borrowlist.Count)
                {
                    Delete_Label.Show();
                    Delete_Label.ForeColor = Color.Red;
                    Delete_Label.Text = "Index out of range.";
                    return;
                }

                // Remove from internal list and ListBox
                Checkout_borrowlist.RemoveAt(listIndex);
                CHECKOUT.Items.RemoveAt(listIndex);

                // Rebuild the ListBox with correct numbering
                CHECKOUT.Items.Clear();
                I = 1;
                foreach (var item in Checkout_borrowlist)
                {
                    CHECKOUT.Items.Add($"({I}) {item.Itemtype}: {item.Itemname}");
                    I++;
                }

                if (Home_form.key == 1)
                {
                    Total_Check.Text = $"Returning {Checkout_borrowlist.Count} item(s)";
                    Total_Check.Show();
                }
                if (Home_form.key == 2)
                {
                    Total_Check.Text = $"Borrowing {Checkout_borrowlist.Count} item(s)";
                    Total_Check.Show();
                }
            }
        }
        private void CheckOut_Final_Click(object sender, EventArgs e)//checkout_Final_button 
        {
            {
                if (Home_form.key == 0)//BUY BUTTON
                {
                    foreach (var item in Checkout_list) 
                    {
                        // Casting & Polymorphism
                        if (item is Book book)
                        {
                            Book? booky = item as Book;
                            int index = CsvFile<Book>.Search(Book.books, booky?.Name ?? "");
                            Book.books[index].quant--;
                        }
                        else
                        {
                            DVD? DVDY = item as DVD;
                            int index = CsvFile<DVD>.Search(DVD.DVDS, DVDY?.Name ?? "");
                            DVD.DVDS[index].quant--;
                        }
                        I++;
                    }
                    //rewriting the CSV file
                    CsvFile<DVD>.Write(DVD.DVD_Path, DVD.DVDS, new DVD.DVDMap());
                    CsvFile<Book>.Write(Book.B_Path, Book.books, new Book.BookMap());
                    if (Total > 0)
                        MessageBox.Show("Transaction complete.");
                    Checkout_list.Clear();
                }
                else if (Home_form.key == 1)//RETURN BUTTON
                {
                    foreach (var item in Checkout_borrowlist)
                    {
                        if (item.Itemtype.ToLower() == "book")
                        {
                            //Searching For the Book in the CSV File
                            int index = CsvFile<Book>.Search(Book.books, item.Itemname);
                            Book.books[index].Borrowed--;
                            Book.books[index].quant++;
                            int index_1 = Borrow.SearchItemName(Borrow.Borrowedlist, item.Itemname);
                            Borrow.Borrowedlist.RemoveAt(index_1);
                        }
                        else
                        {
                            //searcing in the DVD List 
                            int index = CsvFile<DVD>.Search(DVD.DVDS, item.Itemname);
                            //updating the quantity in the DVD List
                            DVD.DVDS[index].Borrowed--;
                            Book.books[index].quant++;
                            //Removing the item form the Borrowed list  
                            int index_1 = Borrow.SearchItemName(Borrow.Borrowedlist, item.Itemname);
                            Borrow.Borrowedlist.RemoveAt(index_1);
                        }
                    }
                    CsvFile<Borrow>.Write(Borrow.Borrow_Path, Borrow.Borrowedlist, new Borrow.Borrowedmap());
                    MessageBox.Show("Item(s) successfully returned.");
                    Checkout_borrowlist.Clear();
                }
                else if (Home_form.key == 2)//BORROW BUTTON
                {
                    foreach (var item in Checkout_borrowlist)
                    {
                        if (item.Itemtype.ToLower() == "book")
                        {
                            //searching for the Book in the Csv File 
                            int index = CsvFile<Book>.Search(Book.books, item.Itemname);
                            Book.books[index].Borrowed++;
                            Book.books[index].quant--;
                        }
                        else
                        {
                            //searching for the DVD in the Csv File 
                            int index = CsvFile<DVD>.Search(DVD.DVDS, item.Itemname);
                            //updating the DVD list 
                            DVD.DVDS[index].Borrowed++;
                            Book.books[index].quant--;
                        }
                        //adding the item to the list 
                        Borrow.Borrowedlist.Add(item);
                    }
                    //rewirting the CSV File
                    CsvFile<Borrow>.Write(Borrow.Borrow_Path, Borrow.Borrowedlist, new Borrow.Borrowedmap());
                    MessageBox.Show("Borrow list updated.");
                    Checkout_borrowlist.Clear();

                }
            }
            //rewriting in the CSV FILES
            CsvFile<DVD>.Write(DVD.DVD_Path, DVD.DVDS, new DVD.DVDMap());
            CsvFile<Book>.Write(Book.B_Path, Book.books, new Book.BookMap());
            // Clearing the Lists
            Checkout_list.Clear();
            Checkout_borrowlist.Clear();
            this.Close();
        }
    }
}
