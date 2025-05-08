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
        public static string BOOK_Fpath = "E:\\Visual Studio Projects\\Library-Management-System\\Books.CSV";
        public static string DVD_Fpath = "E:\\Visual Studio Projects\\Library-Management-System\\DVD.CSV";
        public static string IQGAMES_Fpath = "E:\\Visual Studio Projects\\Library-Management-System\\IQGames.CSV";

        public string Name;
        private string Quant, Price;

        public string price
        {
            get { return Price; }
            set { Price = value; }
        }

        public string quant
        {
            get { return Quant; }
            set { Quant = value; } // Fixed logic to allow zero
        }

        public Inventory() {
            Name = "";
            Quant = "";
            Price = "";
        }
        public virtual void add_item() { }
    }

    public class Book : Inventory
    {
        public string Author, Year;

        public Book() {
            Author = "";
            Year = "";
        }

        public Book(string name, string author, string year, string price)
        {
            this.Name = name;
            this.price = price;
            this.Author = author;
            this.Year = year;
            this.quant = "10"; // Initialize with default quantity
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
                File.AppendAllText(BOOK_Fpath,$"{book.Name},{book.Author},{book.Year},{book.price},{book.quant}\n");
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
                    MessageBox.Show("No books found in database");
                    return new Book();
                }

                var foundBook = books.FirstOrDefault(b =>
                    !string.IsNullOrEmpty(b.Name) &&
                    b.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

                if (foundBook == null)
                {
                    MessageBox.Show($"Book '{searchTerm}' not found");
                    return foundBook;
                }
                else return new Book();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}");
                return new Book(); ;
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