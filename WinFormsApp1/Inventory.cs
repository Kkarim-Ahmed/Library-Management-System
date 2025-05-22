using CsvHelper.Configuration;
using Library_Managment__System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Library_Managment__System
{
    public interface Objects //Public Interface Needed For Generic Class
    {
        public string Name { get; set; }
    }
    }
    public abstract class Inventory: Objects // Abstract Class Inheriting From Objects Interface
    {
    public static List<Book> books = new List<Book>(); // Creates Static List For Books
    public static List<DVD> DVDS = new List<DVD>(); // Creates Static List For Books
    public string Name { get; set; }
    // Encapsulation
    private int Quant;
    private double Price;
    public int quant
        {
        get { return Quant; }
        set { Quant = value; }
        }
    public double price
        {
            get { return Price; }
            set { Price = value; }
        }
        public int Borrowed = 0;
        public Inventory()  // Overriding Default Constructor
        {
            Name = "";
            Quant = 0;
            Price = 0;
        }
        public static void AddItem(Inventory element)
        {
            books = CsvFile<Book>.Read(Book.B_Path,new Book.BookMap()); // Reading CSV For Book
            DVDS = CsvFile<DVD>.Read(DVD.DVD_Path, new DVD.DVDMap()); // Reading CSV For DVD
        if (element is Book book)
            {
            int index = CsvFile<Book>.Search(books, element.Name);// Searches For Book Index To Edit
            if (index != -1) // Checking If Book Exists
                {
                    books[index].quant += book.quant; // Adding Quantity If Book Already Exists
                    MessageBox.Show($"Updated quantity for '{books[index].Name}'. New quantity: {books[index].quant}");
                }
                else
                {
                // Adds The Book If It Doesnt Exist
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
                // Write Data To CSV File
                CsvFile<Book>.Write(Book.B_Path, books, new Book.BookMap());
            }
            else if (element is DVD dvd)
            {
            int index = CsvFile<DVD>.Search(DVDS, element.Name); // Checks If DVDS Exist
                if (index != -1)
                {
                DVDS[index].quant += dvd.quant; // Adds Quantity If DVD Already Exists
                    MessageBox.Show($"Updated quantity for '{DVDS[index].Name}'. New quantity: {DVDS[index].quant}");
                }
                else
                {
                // Adds The New Book
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
                // Writes Data To CSV File
                CsvFile<DVD>.Write(DVD.DVD_Path, DVDS, new DVD.DVDMap());
            }
        }
    }

    public class Book : Inventory,Objects // Book Class Inheriting From Inventory Class And Objects Interface
    {
	public static string B_Path = "Books.csv"; // Book CSV File Path
    public string Author, Year;
    
    // Overloading Default Constructor
    public Book() 
        {
            Author = "";
            Year = "";
        }

    // Custom Constructor To Set Values
    public Book(string name, string author, string year, double price, int quant)
        {
            this.Name = name;
            this.price = price;
            this.Author = author;
            this.Year = year;
            this.quant = quant;
        }

        //Book Map For CSV Mapping
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
    }
        public class DVD : Inventory,Objects
        {
        //DVD File Path
	    public static string DVD_Path = "DVDS.csv";
            // Encapsulation Properties
            private string genre = "";
            private string duration ="";
            private string year = "";
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

            // Default Constructor
            public DVD() { }
            // Custom Constructor
            public DVD(string name, string genre, string duration, double price, int quant,string year) 
    {
                this.Name = name;
                this.Genre = genre;
                this.Duration = duration;
                this.price = price;
                this.quant = quant;
                this.year = year;
            }
        //DVD Map For CSV Mapping
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
    }
