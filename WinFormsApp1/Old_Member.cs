//using CSVClass;
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
//using Inventory;

namespace Library_Managment__System
{

    public partial class Old_Member : Form
    {
        public static double Total = 0;

        List<Objects> Checkout_list = new List<Objects>();// Buy List
        List<Borrow> Checkout_borrowlist = new List<Borrow>();//Borrow , return  list
        public static int I ;

        public Old_Member()
        {

            I = 1;

        InitializeComponent();
            BOOKS_COMBO.DataSource = Book.books;
            BOOKS_COMBO.DisplayMember = "Name";
            BOOKS_COMBO.ValueMember = "Name"; ;
            BOOKS_COMBO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            BOOKS_COMBO.AutoCompleteSource = AutoCompleteSource.ListItems;
            BOOKS_COMBO.DropDownStyle = ComboBoxStyle.DropDown;

            DVD_COMBO.DataSource = DVD.DVDS;
            DVD_COMBO.DisplayMember = "Name";
            DVD_COMBO.ValueMember = "Name";
            DVD_COMBO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DVD_COMBO.AutoCompleteSource = AutoCompleteSource.ListItems;
            DVD_COMBO.DropDownStyle = ComboBoxStyle.DropDown;



        }
        private void phone_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)//serach name and phone 
        {
            int index = CsvFile<Members>.Search(Members.Memberlist, old_name.Text);
            if (index == -1)
            {
                MessageBox.Show("Check Member credentials"); this.Close();
            }
            else if (Members.Memberlist[index].Name.ToLower() == old_name.Text.ToLower() && Members.Memberlist[index].PhoneNumber == phone_number.Text)
            {
                MessageBox.Show("Bono");

            }
            else
            {
                MessageBox.Show("Wrong Phone Number Please Check");
            }
        }

        private void button2_Click(object sender, EventArgs e)//ADD BOOK BUTTON
        {
            if (Home_form.key == 0)//BUY FORM
            {
                int index = CsvFile<Book>.Search(Book.books, BOOKS_COMBO.Text);
                if (index == -1) { MessageBox.Show("not found"); }
                else
                {
                    MessageBox.Show("found");
                    Checkout_list.Add(Book.books[index]);
                    CHECKOUT.Text += $" ({I})_BOOK :: {Book.books[index].Name} $ {Book.books[index].price}\n";
                    Total += Book.books[index].price;
                    Total_Check.Text = $"Total : ${Total}";
                    I++;
                }

            }
            else if (Home_form.key == 2)//Borrow FORM
            {
                int index = CsvFile<Book>.Search(Book.books, BOOKS_COMBO.Text);
                if (index == -1) { MessageBox.Show("not found"); }
                else
                {
                    MessageBox.Show("found");
                    Checkout_borrowlist.Add(new Borrow(old_name.Text.ToLower(), Book.books[index].Name, "Book", DateAndTime.DateString));
                    CHECKOUT.Text += $" ({I})_BOOK :: {Book.books[index].Name}\n";
                    Total_Check.Text = $"Borrowing {I} Item(s)";
                    I++;
                    
                }
            }
            else if (Home_form.key == 1)// Return Form
            {
                int index;
                var list = Borrow.FindBorrowed(old_name.Text.ToLower());
                index = CsvFile<Book>.Search(Book.books, BOOKS_COMBO.Text);
                foreach (var item in list)
                {
                    if (item.Itemname.ToLower() == BOOKS_COMBO.Text.ToLower() && item.Itemtype.ToLower() == "book")
                    {
                        index = CsvFile<Book>.Search(Book.books, item.Itemname);
                        if (index != -1)
                        {
                            Checkout_borrowlist.Add(item);
                            if (Checkout_borrowlist[I - 1].Duedate == DateTime.Now.ToString()) Total+= Checkout_borrowlist[I-1].price*0.1;
                            break;
                        }
                    }

                }
                CHECKOUT.Text += $" ({I})_BOOK:: {Checkout_borrowlist[I-1].Itemname}\n";
                Total_Check.Text = $"Returning {I} Item(s)";

                I++;

            }

        }

        private void button3_Click(object sender, EventArgs e)//ADD DVD BUTTON
        {
            if (Home_form.key == 0)//BUY FORM
            {
                int index = CsvFile<DVD>.Search(DVD.DVDS, DVD_COMBO.Text);
                if (index == -1) { MessageBox.Show("not found"); }
                else
                {
                    MessageBox.Show("found");
                    Checkout_list.Add(DVD.DVDS[index]);
                    CHECKOUT.Text += $" ({I})DVD :: {DVD.DVDS[index].Name} $ {DVD.DVDS[index].price}\n";
                    I++;
                    Total += DVD.DVDS[index].price;
                    Total_Check.Text = $"Total : ${Total}";
                }
            }
            else if (Home_form.key == 2)//BORROW form
            {
                int index = CsvFile<DVD>.Search(DVD.DVDS, DVD_COMBO.Text);
                if (index == -1) { MessageBox.Show("not found"); }
                else
                {
                    MessageBox.Show("found");
                    Checkout_borrowlist.Add(new Borrow(old_name.Text.ToLower(), DVD.DVDS[index].Name, "DVD", DateAndTime.DateString));
                    CHECKOUT.Text += $" ({I})_DVD :: {DVD.DVDS[index].Name} \n";
                    Total_Check.Text = $"Borrowing {I} Item(s)";
                    I++;
                }
            }
            else if (Home_form.key == 1)//Return Form
            {
                int index;
                var list = Borrow.FindBorrowed(old_name.Text.ToLower());
                index = CsvFile<DVD>.Search(DVD.DVDS, DVD_COMBO.Text);
                foreach (var item in list)
                {
                    if (item.Itemname.ToLower() == DVD_COMBO.Text.ToLower() && item.Itemtype.ToLower() == "dvd")
                    {
                        index = CsvFile<DVD>.Search(DVD.DVDS, item.Itemname);
                        if (index != -1)
                        {
                            Checkout_borrowlist.Add(item);
                            break;
                        }
                    }

                }
                CHECKOUT.Text += $" ({I})_DVD :: {Checkout_borrowlist[I-1].Itemname}\n";
                Total_Check.Text = $"Returning {I} Item(s)";

                I++;
            }
        }

        private void button4_Click(object sender, EventArgs e)//DELete Button
        {

            if (Home_form.key == 0)//BUY FORM
            {
                int ind = int.Parse(Delete_Index.Text);
                Checkout_list.RemoveAt(ind-1);
                CHECKOUT.Text = "";
                I = 1;
                Total = 0;
                foreach (var item in Checkout_list)
                {
                    if (item is Book book)
                    {
                        Book booky = item as Book;

                        CHECKOUT.Text += $" ({I})_BOOK :: {item.Name} $ {booky.price}\n";
                        I++;
                        Total += booky.price;

                    }
                    else
                    {
                        DVD DVDY = item as DVD;
                        CHECKOUT.Text += $" ({I})_DVD :: {item.Name} $ {DVDY.price}\n";
                        I++;
                        Total += DVDY.price;

                    }

                }
            }
            else//return and Borrow form
            {
                if (!int.TryParse(Delete_Index.Text, out int l) || l <= 0)
                {
                    MessageBox.Show("Please enter a valid item number.");
                    return;
                }

                int ind = int.Parse(Delete_Index.Text);
                Checkout_borrowlist.RemoveAt(ind-1 );
                CHECKOUT.Text = "";
                I = 1;
                Total = 0;
                
                foreach (var item in Checkout_borrowlist)
                {
                  CHECKOUT.Text += $" ({I++})_{item.Itemtype.ToUpper()} :: " +item.Itemname+"\n";
                  
                }
                if (Home_form.key == 1)
                    Total_Check.Text = $"Returning {I} Item(s)";
                    if (Home_form.key ==2)
                Total_Check.Text = $"Borrowing {I} Item(s)";

            }
        }

        private void Old_Member_Load(object sender, EventArgs e)
        {



        }

        private void CheckOut_Final_Click(object sender, EventArgs e)
        {
            {
                if (Home_form.key == 0)//BUY BUTTON
                {
                    foreach (var item in Checkout_list)
                    {
                        if (item is Book book)
                        {
                            Book booky = item as Book;
                            int index = CsvFile<Book>.Search(Book.books, booky.Name);
                            Book.books[index].quant--;
                            I++;
                        }
                        else
                        {
                            DVD DVDY = item as DVD;
                            int index = CsvFile<DVD>.Search(DVD.DVDS, DVDY.Name);
                            DVD.DVDS[index].quant--;
                            I++;
                        }
                    }
                    CsvFile<DVD>.Write(DVD.DVD_Path, DVD.DVDS, new DVD.DVDMap());
                    CsvFile<Book>.Write(Book.B_Path, Book.books, new Book.BookMap());
                    if (Total > 0)
                        MessageBox.Show("Transaction Complete");
                }
                //----------------------------------------------------
                else if (Home_form.key == 1)//RETURN BUTTON??<O$KELA
                {
                    foreach (var item in Checkout_borrowlist)
                    {
                        if (item.Itemtype.ToLower() == "book")
                        {
                            int index = CsvFile<Book>.Search(Book.books, item.Itemname);
                            Book.books[index].Borrowed--;
                            Book.books[index].quant++;
                            int index_1 = Borrow.SearchItemName(Borrow.Borrowedlist, item.Itemname);
                            Borrow.Borrowedlist.RemoveAt(index_1);
                        }
                        else
                        {
                            int index = CsvFile<DVD>.Search(DVD.DVDS, item.Itemname);
                            DVD.DVDS[index].Borrowed--;
                            Book.books[index].quant++;
                            int index_1 = Borrow.SearchItemName(Borrow.Borrowedlist, item.Itemname);
                            Borrow.Borrowedlist.RemoveAt(index_1);
                        }
                    }
                    CsvFile<Borrow>.Write(Borrow.Borrow_Path, Borrow.Borrowedlist, new Borrow.Borrowedmap());
                    MessageBox.Show("Items(s) Succesfully Returned");
                }

                //---------------------------------------------------------------
                else if (Home_form.key == 2)//BORROW BUTTON// sa7
                {
                    foreach (var item in Checkout_borrowlist)
                    {
                        if (item.Itemtype.ToLower() == "book")
                        {
                            int index = CsvFile<Book>.Search(Book.books, item.Itemname);
                            Book.books[index].Borrowed++;
                            Book.books[index].quant--;

                            Borrow.Borrowedlist.Add(item);
                            ;
                        }
                        else
                        {
                            int index = CsvFile<DVD>.Search(DVD.DVDS, item.Itemname);
                            DVD.DVDS[index].Borrowed++;
                            Book.books[index].quant--;
                            Borrow.Borrowedlist.Add(item);

                        }

                    }
                    CsvFile<Borrow>.Write(Borrow.Borrow_Path, Borrow.Borrowedlist, new Borrow.Borrowedmap());

                    MessageBox.Show("Borrow List Updated");

                }
                Total = 0;
            }
            CsvFile<DVD>.Write(DVD.DVD_Path, DVD.DVDS, new DVD.DVDMap());
            CsvFile<Book>.Write(Book.B_Path, Book.books, new Book.BookMap());
            Checkout_list.Clear();
            Checkout_borrowlist.Clear();
            this.Close();
        }
        
    }
}