using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

namespace Inventory
{
    public abstract class Inventory
    {
        //D:\New folder (3)
        //E:\Git Repos\Library-Management-System
        public static string BOOK_Fpath = "E:\\Git Repos\\Library-Management-System\\Books.CSV";
        public static string DVD_Fpath = "E:\\Git Repos\\Library-Management-System\\DVD.CSV";
        public static string IQGAMES_Fpath = "E:\\Git Repos\\Library-Management-System\\IQGames.CSV";

        public string Name { get; set; }  // Replaces the public field

        private int Quant, Price;

        public int price
        {
            get { return Price; }
            set { Price = value; }
        }

        public int quant { get { return Quant;} set { Quant = value; } }
                public Inventory() {
            Name = "";
            Quant = 0;
            Price = 0;
        }
        public virtual void add_item() { }
    }

    public class Book : Inventory
    {
        public string Author {get;set;}
        public string Year { get; set; }

        public Book() {
            Author = "";
            Year = "";
        }

        public Book(string name, string author, string year, int price,int quant)
        {
            this.Name = name;
            this.price = price;
            this.Author = author;
            this.Year = year;
            this.quant = quant; 
        }
        public static void WriteBooks(List<Book> books)
        { 
            try
            {
                using (var writer = new StreamWriter(BOOK_Fpath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    // Register the mapping class
                    csv.Context.RegisterClassMap<BookMap>();
                    csv.WriteRecords(books);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to CSV: {ex.Message}");
            }
        }


        public static void Add_Book_csv(Book book)
        {
            try
            {

                if (!File.Exists(BOOK_Fpath))
                {
                    File.WriteAllText(BOOK_Fpath, "Name,Author,Year,Price,Quant\n");
                    MessageBox.Show("file Created ");
                }
                List<Book> mylist = Book.Readbooks();
                int index = Book.Search(mylist, book.Name);
                if (index != -1)
                {
                    if (mylist[index].Name.ToLower() == book.Name.ToLower() && mylist[index].Author.ToLower() == book.Author.ToLower())
                    {
                        mylist[index].quant += book.quant;
                        Book.WriteBooks(mylist);
                        return;
                    }
                }
                    File.AppendAllText(BOOK_Fpath, $"{book.Name.ToLower()},{book.Author.ToLower()},{book.Year},{book.price},{book.quant}\n");
                }



            catch (Exception ex)
            {
                MessageBox.Show($"Error saving book: {ex.Message}");
            }
        }

        public static List<Book> Readbooks()
        {
            try
            {
                if (!File.Exists(BOOK_Fpath))
                {
                    return new List<Book>();
                }

                using (var reader = new StreamReader(BOOK_Fpath))
                using (var csv = new CsvReader(reader,
                    new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = true,
                        MissingFieldFound = null,
                        BadDataFound = null
                    }))
                {
                    csv.Context.RegisterClassMap<BookMap>();
                    return csv.GetRecords<Book>().ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading books: {ex.Message}");
                return new List<Book>();
            }
        }
        public static Book Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a search term");
                return new Book();
            }

            try
            {
                var books = Readbooks();
                if (books == null || books.Count == 0)
                {
                    return new Book();
                }

                var foundBook = books.FirstOrDefault(b =>
                    !string.IsNullOrEmpty(b.Name) &&
                    b.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

                if (foundBook == null)
                {
                    MessageBox.Show($"Book '{searchTerm}' not found");
                    return new Book();
                }
                else return foundBook;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}");
                return new Book(); ;
            }
        }
        public static int Search(List<Book> Books, string searchTerm)
        {
            try
            {
                var books =Books;
                if (books == null || books.Count == 0)
                {
                    MessageBox.Show("No books found in database");
                    return -1;
                }
                var foundBook = books.FirstOrDefault(b =>
                    !string.IsNullOrEmpty(b.Name) &&
                    b.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

                int index = books.FindIndex(b =>
            !string.IsNullOrEmpty(b.Name) &&
            b.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

                if (foundBook == null)
                {
                    MessageBox.Show($"Book '{searchTerm}' not found");
                    return -1;
                }
                else return index;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}");
                return -1 ;
            }
        }
        public sealed class BookMap : ClassMap<Book>
        {
            public BookMap()
            {
                Map(m => m.Name).Name("Name");
                Map(m => m.Author).Name("Author");
                Map(m => m.Year).Name("Year");
                Map(m => m.price).Name("Price");
                Map(m => m.quant).Name("Quant");
            }
        }
    }
}