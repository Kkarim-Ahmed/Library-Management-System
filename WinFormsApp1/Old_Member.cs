using CsvHelper.Configuration.Attributes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            BOOKS_COMBO.ValueMember = "Name"; ;
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
            // hiding buttons untill we found the user in the Csv file .
            button2.Hide();
            button3.Hide();
        }
        private void phone_number_KeyPress(object sender, KeyPressEventArgs e)// Data validation to type only digits in phone number
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)//button serach name and phone 
        {
            int index = CsvFile<Members>.Search(Members.Memberlist, old_name.Text);// searching in the CSV File (function in methods class)
            if (index == -1)//Not Found in the CSV File
            {
                Search_label.ForeColor = Color.Red;
                Search_label.Text="Check Member credentials";
                
            }// found with the right phone number.
            else if (Members.Memberlist[index].PhoneNumber == phone_number.Text)
            {
                Search_label.ForeColor = Color.Green;
                Search_label.Text = "Verified";
                // Showing Buttons Add Book and DVD And Combo boxes
                button2.Show();
                button3.Show();
                BOOKS_COMBO.Show();
                DVD_COMBO.Show();
            }
            else// Name Found But worng Phone Number
            {
                Search_label.ForeColor= Color.Red;
                Search_label.Text= "Wrong Phone Number Please Check";
            }
        }
        private void button2_Click(object sender, EventArgs e)//ADD BOOK BUTTON
        {
            int index = CsvFile<Book>.Search(Book.books, BOOKS_COMBO.Text);//Searching in the Books Csv
            //Check if the book Exicted in the Books csv and if not he will excute the funtion.
            if (index == -1) { SearchBooks_label.ForeColor = Color.Red; SearchBooks_label.Text = "Not Found";return;}
            
            if      (Home_form.key == 0) //BUY Button
            { 
                    Checkout_list.Add(Book.books[index]);//Adding to Checkout List
                    Total += Book.books[index].price;//updating Total price
                    // updating GUI
                    CHECKOUT.Text += $" ({I})_BOOK :: {Book.books[index].Name} $ {Book.books[index].price}\n";
                    Total_Check.Text = $"Total : ${Total}";
                    SearchBooks_label.ForeColor = Color.Green; SearchBooks_label.Text = "Found";
                    I++;

            }
            else if (Home_form.key == 1)// Return Form
            {
                bool found=false;
                var list = Borrow.FindBorrowed(old_name.Text.ToLower());//all borrowed books buy the user 
                foreach (var item in list)//loop in the list
                {
                    //check if the book founded in the list 
                    if (item.Itemname.ToLower() == BOOKS_COMBO.Text.ToLower() && item.Itemtype.ToLower() == "book")
                    {
                        found = true;
                        //add borrow list
                               Checkout_borrowlist.Add(item);
                        //check for due date
                               if (Checkout_borrowlist[I - 1].Duedate == DateTime.Now.ToString()) Total += Checkout_borrowlist[I - 1].price * 0.1;
                        //updating GUI     
                               CHECKOUT.Text += $" ({I})_BOOK:: {Checkout_borrowlist[I - 1].Itemname}\n";
                               Total_Check.Text = $"Returning {I} Item(s)";
                               SearchBooks_label.ForeColor = Color.Green; 
                               SearchBooks_label.Text = "Found";
                               I++;
                        //break the Foreach if Found 
                        break;      
                    }
                }
                if (!found) //Updating GUI IF the user didnot borrow the book
                {
                    SearchBooks_label.ForeColor = Color.Red;
                    SearchBooks_label.Text = "The User Didn't Borrow This Book";
                }
            }
            else if (Home_form.key == 2)//Borrow FORM
            {
                //adding to checkout_borrow list.
                Checkout_borrowlist.Add(new Borrow(old_name.Text.ToLower(), Book.books[index].Name, "Book", DateAndTime.Now.AddDays(14).ToString()));
                //updating to the GUI
                CHECKOUT.Text += $" ({I})_BOOK :: {Book.books[index].Name}\n";
                Total_Check.Text = $"Borrowing {I} Item(s)";
                SearchBooks_label.ForeColor = Color.Green; SearchBooks_label.Text = "Found";
                I++;

            }

        }
        private void button3_Click(object sender, EventArgs e)//ADD DVD BUTTON
        {
            // serching the DVD in the DVD file
            int index = CsvFile<DVD>.Search(DVD.DVDS, DVD_COMBO.Text);
            // break from the Function if the Book Not Found 
            if (index == -1) { SearchDVD_label.ForeColor=Color.Red; SearchDVD_label.Text="Not Found";return;}
            if      (Home_form.key == 0)//BUY FORM
            {
                //Addind to Checkout list
                    Checkout_list.Add(DVD.DVDS[index]);
                //Updating the GUI
                    CHECKOUT.Text += $" ({I})DVD :: {DVD.DVDS[index].Name} $ {DVD.DVDS[index].price}\n";
                    Total_Check.Text = $"Total : ${Total}";
                    SearchDVD_label.ForeColor = Color.Green; SearchDVD_label.Text = "Found";
                    I++;
            }
            else if (Home_form.key == 1)//Return Form
            {
                bool found = false;
                //storing the Borrowed list in a list
                var list = Borrow.FindBorrowed(old_name.Text.ToLower());
                foreach (var item in list)
                {
                    if (item.Itemname.ToLower() == DVD_COMBO.Text.ToLower() && item.Itemtype.ToLower() == "dvd")
                    {
                        found = true;
                        Checkout_borrowlist.Add(item);//Adding DVD to the CheckoutList
                        if (Checkout_borrowlist[I - 1].Duedate == DateTime.Now.ToString()) Total += Checkout_borrowlist[I - 1].price * 0.1;
                        //Updating The GUI
                        SearchDVD_label.ForeColor = Color.Green;
                        SearchDVD_label.Text = "Found";
                        CHECKOUT.Text += $" ({I})_DVD :: {Checkout_borrowlist[I - 1].Itemname}\n";
                        Total_Check.Text = $"Returning {I} Item(s)";
                        I++;
                        break;
                    }
                }
                if (!found) { SearchDVD_label.ForeColor = Color.Red;SearchDVD_label.Text = "The user Didnot Borrow DVD"; }

            }
            else if (Home_form.key == 2)//BORROW form
            {
                    Checkout_borrowlist.Add(new Borrow(old_name.Text.ToLower(), DVD.DVDS[index].Name, "DVD", DateAndTime.DateString));
                    SearchDVD_label.ForeColor= Color.Green;
                    SearchDVD_label.Text = "Found";
                    CHECKOUT.Text += $" ({I})_DVD :: {DVD.DVDS[index].Name} \n";
                    Total_Check.Text = $"Borrowing {I} Item(s)";
                    I++;
            }
        }
        private void button4_Click(object sender, EventArgs e)//DELETE BUTTON
        {
            if (!int.TryParse(Delete_Index.Text, out int ind) || ind <= 0)//Index You Want To Delete
            {
                MessageBox.Show("Please enter a valid item number.");
                return;
            }
            CHECKOUT.Text = "";//deleting Checkout label text
            I = 1;//reintializing the counter for the label 
            Total = 0;
            if (Home_form.key == 0) //BUY FORM
            {
                Checkout_list.RemoveAt(ind - 1);
                //rewriting the Check_out_list
                foreach (var item in Checkout_list)
                {
                    if (item is Book book)//applying polymorpism
                    {
                        Book? booky = item as Book;//applying casting 
                        //updating the GUI
                        CHECKOUT.Text += $" ({I})_BOOK :: {item.Name} $ {booky?.price}\n";
                        Total += booky.price;
                        I++;
                    }
                    else
                    {
                        DVD? DVDY = item as DVD;//applying casting 
                        //applying Casting
                        CHECKOUT.Text += $" ({I})_DVD :: {item.Name} $ {DVDY.price}\n";
                        Total += DVDY.price;
                        I++;
                    }

                }
            }
            else//return and Borrow form
            {
                Checkout_borrowlist.RemoveAt(ind - 1);
                foreach (var item in Checkout_borrowlist)
                {
                  CHECKOUT.Text += $" ({I})_{item.Itemtype.ToUpper()} :: " +item.Itemname+"\n";
                  I++;
                }
                if (Home_form.key == 1) Total_Check.Text = $"Returning {I-1} Item(s)";
                if (Home_form.key == 2) Total_Check.Text = $"Borrowing {I-1} Item(s)";

            }
        }
        private void CheckOut_Final_Click(object sender, EventArgs e)//checkout_Final_button 
        {
            {
                if (Home_form.key == 0)//BUY BUTTON
                {
                    foreach (var item in Checkout_list)
                    {
                        if (item is Book book)
                        {
                            Book? booky = item as Book;//applying Casting
                            int index = CsvFile<Book>.Search(Book.books, booky.Name);//serahing in Books List
                            Book.books[index].quant--;//updating Quantity
                        }
                        else
                        {
                            DVD? DVDY = item as DVD;//applying Casting
                            int index = CsvFile<DVD>.Search(DVD.DVDS, DVDY.Name);//serahing in DVD List
                            DVD.DVDS[index].quant--;//updating Quantity
                        }
                        I++;

                    }
                    //updating the Csv File 
                    CsvFile<DVD>.Write(DVD.DVD_Path, DVD.DVDS, new DVD.DVDMap());
                    CsvFile<Book>.Write(Book.B_Path, Book.books, new Book.BookMap());
                    if (Total > 0)
                        MessageBox.Show("Transaction Complete");
                }
                //----------------------------------------------------
                else if (Home_form.key == 1)//RETURN BUTTON
                {
                    foreach (var item in Checkout_borrowlist)
                    {
                        if (item.Itemtype.ToLower() == "book")
                        {
                            //searcing in the Book List 
                            int index = CsvFile<Book>.Search(Book.books, item.Itemname);
                            //updating the quantity in the Books List
                            Book.books[index].Borrowed--;
                            Book.books[index].quant++;
                            //Removing the item form the Borrowed list  
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
                    //updating the borrowed CSV File 
                    CsvFile<Borrow>.Write(Borrow.Borrow_Path, Borrow.Borrowedlist, new Borrow.Borrowedmap());
                    MessageBox.Show("Items(s) Succesfully Returned");
                }
                //---------------------------------------------------------------
                else if (Home_form.key == 2)//BORROW BUTTON/
                {
                    foreach (var item in Checkout_borrowlist)
                    {
                        if (item.Itemtype.ToLower() == "book")
                        {
                            //searching for the Book in the Csv File 
                            int index = CsvFile<Book>.Search(Book.books, item.Itemname);
                            //updating the books list 
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
                    MessageBox.Show("Borrow List Updated");

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