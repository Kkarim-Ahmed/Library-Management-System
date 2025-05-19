//using CSVClass;
//using CSVClass;
using CsvHelper.Configuration;
using Library_Managment__System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Library_Managment__System
{
    public interface Objects
    {
        public string Name { get; set; }
    }
    }
    public abstract class Inventory: Objects
    {
        public string Name { get; set;}
        public static List<Book> books = new List<Book>();
        public static List<DVD> DVDS = new List<DVD>();
        
        

        private int Quant;
        private double Price;

        public double price
        {
            get { return Price; }
            set { Price = value; }
        }
        public Inventory()
        {
            Name = "";
            Quant = 0;
            Price = 0;
        }

        public int quant
        {
            get { return Quant; }
            set { Quant = value; }
        }



        public static void AddItem(Inventory element)
        {
            books = CsvFile<Book>.Read(Book.B_Path,new Book.BookMap());
            DVDS = CsvFile<DVD>.Read(DVD.DVD_Path, new DVD.DVDMap());

            if (element is Book book)
            {
                Book existingBook = Book.Find_Book(book.Name);
                if (existingBook != null)
                {
                    int index = CsvFile<Book>.Search(books,book.Name);
                    books[index].quant += book.quant;
                    MessageBox.Show($"Updated quantity for '{existingBook.Name}'. New quantity: {books[index].quant}");
                }
                else
                {
                    books.Add(new Book
                    {
                        Name = book.Name,
                        Year = book.Year,
                        Author = book.Author,
                        price = book.price,
                        quant = book.quant
                    });
                    MessageBox.Show($"Added new book '{book.Name}' to inventory");

                }
                CsvFile<Book>.Write(Book.B_Path, books, new Book.BookMap());

            }
            else if (element is DVD dvd)
            {
                DVD existingDVD = DVD.Find_DVD(dvd);
                if (existingDVD != null)
                {
                    existingDVD.quant += dvd.quant;
                    MessageBox.Show($"Updated quantity for '{existingDVD.Name}'. New quantity: {existingDVD.quant}");
                }

                else
                {
                    DVDS.Add(new DVD(
                        year: dvd.Year,
                        name: dvd.Name,
                        genre: dvd.Genre,
                        duration: dvd.Duration,
                        price: dvd.price,
                        quant: dvd.quant
                    ));
                    MessageBox.Show($"Added new book '{dvd.Name}' to inventory");
                }
                CsvFile<DVD>.Write(DVD.DVD_Path, DVDS, new DVD.DVDMap());

            }
        }
    }

    public class Book : Inventory,Objects
    {

	public static string B_Path = "D:\\Programing\\GitHub Repos\\Library-Management-System\\Books.csv";
        public string Name{ get; set; }
        
        public string Author, Year;

        public int Borrowed;

        public Book()
        {
            Author = "";
            Year = "";
        Borrowed = 0;
        }

        public Book(string name, string author, string year, double price, int quant)
        {
            this.Name = name;
            this.price = price;
            this.Author = author;
            this.Year = year;
            this.quant = quant;
            this.Borrowed = 0;
        }
        public class BookMap : ClassMap<Book>
        {
            public BookMap()
            {
                Map(m => m.Name).Name("Name");
                Map(m => m.Author).Name("Author");
                Map(m => m.Year).Name("Year");
                Map(m => m.price).Name("Price");
                Map(m => m.quant).Name("Quant");
                Map(m => m.Borrowed).Name("Borrowed");
            }
        }

        public static new Book Find_Book(string book)
        {
            return books.FirstOrDefault(b =>
                b.Name.Equals(book, StringComparison.OrdinalIgnoreCase));
        }
    }
        public class DVD : Inventory,Objects
        {
	public string Key { get; set; }

	public static string DVD_Path = "D:\\Programing\\GitHub Repos\\Library-Management-System\\DVDS.csv";

        public string Name { get; set; }
            private string genre = "";
            private string duration ="";
            private string year = "";
            public int Borrowed;
            public string Year
            {
                get { return year; }
                set { year = value; }
            }

            public string Genre
            {
                get => genre;
                set => genre = value;
            }

            public string Duration
            {
                get => duration;
                set => duration = value;
            }
            public DVD() { }

            public DVD(string name, string genre, string duration, double price, int quant,string year)
            {
                this.Name = name;
                this.Genre = genre;
                this.Duration = duration;
                this.price = price;
                this.quant = quant;
                this.year = year;
                this.Borrowed = 0;
            }
        public class DVDMap : ClassMap<DVD>
        {
            public DVDMap()
            {
                Map(m => m.Name).Name("Name");
                Map(m => m.Genre).Name("Genre");
                Map(m => m.Duration).Name("Duration");
                Map(m => m.Year).Name("Year");
                Map(m => m.price).Name("Price");
                Map(m => m.quant).Name("Quant");
                Map(m => m.Borrowed).Name("Borrowed");
            }
        }
        

        public static new DVD Find_DVD(DVD dvd)
            {
                return DVDS.FirstOrDefault(d =>
                    d.Name.Equals(dvd.Name, StringComparison.OrdinalIgnoreCase));
            }
        }
