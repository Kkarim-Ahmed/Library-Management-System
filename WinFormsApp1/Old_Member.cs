//using CSVClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        public static int Total = 0;

        List<Objects> Checkout_list = new List<Objects>();

        public int I = 1;
        public Old_Member()
        {
            Inventory.books = CsvFile<Book>.Read(Book.B_Path, new Book.BookMap());
            Inventory.DVDS = CsvFile<DVD>.Read(DVD.DVD_Path, new DVD.DVDMap());
            Members.Memberlist = CsvFile<Members>.Read(Members.M_Path, new Members.MemberMap());
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
        private void button5_Click(object sender, EventArgs e)
        {
            int index = CsvFile<Members>.Search(Members.Memberlist, old_name.Text);
            if (index == -1)
            {
                MessageBox.Show("Check Member credentials"); this.Close();
            }
            else if (Members.Memberlist[index].Name == old_name.Text && Members.Memberlist[index].PhoneNumber == phone_number.Text)
            {
                MessageBox.Show("Bono");
            }
            else
            {
                MessageBox.Show("Wrong Phone Number Please Check");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = CsvFile<Book>.Search(Book.books, BOOKS_COMBO.Text);
            if (index == -1) { MessageBox.Show("not found"); }
            else
            {
                MessageBox.Show("found");
                Checkout_list.Add(Book.books[index]);
                CHECKOUT.Text += $" {I} : {Book.books[index].Name} $ {Book.books[index].price}\n";
                I++;
                if (Home_form.key==0)
                Total += Book.books[index].price;
                if (Home_form.key == 0)
                    Total_Check.Text = $"Total : ${Total}";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = CsvFile<DVD>.Search(DVD.DVDS, DVD_COMBO.Text);
            if (index == -1) { MessageBox.Show("not found"); }
            else
            {
                MessageBox.Show("found");
                Checkout_list.Add(DVD.DVDS[index]);
                CHECKOUT.Text += $" {I} : {DVD.DVDS[index].Name} $ {DVD.DVDS[index].price}\n";
                I++;
                if (Home_form.key==0)
                Total += DVD.DVDS[index].price;
                Total_Check.Text = $"Total : ${Total}";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ind = int.Parse(Delete_Index.Text);
            Checkout_list.RemoveAt(ind - 1);
            CHECKOUT.Text = "";
            I = 1;
            Total = 0;
            foreach (var item in Checkout_list)
            {
                if (item is Book book)
                {
                    Book booky = item as Book;

                    CHECKOUT.Text += $" {I} : {item.Name} $ {booky.price}\n";
                    I++;
                    Total += booky.price;

                }
                else
                {
                    DVD DVDY = item as DVD;
                    CHECKOUT.Text += $" {I} : {item.Name} $ {DVDY.price}\n";
                    I++;
                    Total += DVDY.price;

                }

            }
            Total_Check.Text = $"Total : ${Total}";
        }

        private void Old_Member_Load(object sender, EventArgs e)
        {
           

        
        }

        private void CheckOut_Final_Click(object sender, EventArgs e)
        {
            {
                foreach (var item in Checkout_list)
                {
                    if (item is Book book)
                    {
                        Book booky = item as Book;

                        int index = CsvFile<Book>.Search(Book.books, booky.Name);
                        if (Home_form.key == 0)
                            Book.books[index].quant--;
                        else if (Home_form.key == 1)
                            Book.books[index].quant++;
                        I++;


                    }
                    else
                    {
                        DVD DVDY = item as DVD;
                        int index = CsvFile<DVD>.Search(DVD.DVDS, DVDY.Name);
                        if (Home_form.key == 0)
                            DVD.DVDS[index].quant--;
                        else if (Home_form.key == 1) 
                            DVD.DVDS[index].quant++;
                            I++;
                    }
                }
                CsvFile<DVD>.Write(DVD.DVD_Path, DVD.DVDS, new DVD.DVDMap());
                CsvFile<Book>.Write(Book.B_Path, Book.books, new Book.BookMap());
                Form form = new Home_form();
                this.Close();
                MessageBox.Show("Transaction Complete");

            }
            Total = 0;
        }
        
    }
}