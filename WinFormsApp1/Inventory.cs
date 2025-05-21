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
    private int Quant, Price;
    public int quant
        {
        get { return Quant; }
        set { Quant = value; }
        }
    public int price
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
                Book existingBook = Book.Find_Book(book.Name);
                if (existingBook != null) // Checking If Book Exists
                {
                    int index = CsvFile<Book>.Search(books,book.Name); // Searches For Book Index To Edit
                    books[index].quant += book.quant; // Adding Quantity If Book Already Exists
                    MessageBox.Show($"Updated quantity for '{existingBook.Name}'. New quantity: {books[index].quant}");
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
                DVD existingDVD = DVD.Find_DVD(dvd); // Checks If DVDS Exist
                if (existingDVD != null)
                {
                    existingDVD.quant += dvd.quant; // Adds Quantity If DVD Already Exists
                    MessageBox.Show($"Updated quantity for '{existingDVD.Name}'. New quantity: {existingDVD.quant}");
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
	public static string B_Path = "D:\\Programing\\GitHub Repos\\Library-Management-System\\Books.csv"; // Book CSV File Path
    public string Author, Year;
    
    // Overloading Default Constructor
    public Book() 
        {
            Author = "";
            Year = "";
        }

    // Custom Constructor To Set Values
    public Book(string name, string author, string year, int price, int quant)
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
        
        
        public static Book Find_Book(string book)
        {
            return books.FirstOrDefault(b =>
                b.Name.Equals(book, StringComparison.OrdinalIgnoreCase)) ?? new Book { Name = "Unknown", Author = "N/A" }; ;
        }
    }
        public class DVD : Inventory,Objects
        {
        //DVD File Path
	    public static string DVD_Path = "D:\\Programing\\GitHub Repos\\Library-Management-System\\DVDS.csv";
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
            public DVD(string name, string genre, string duration, int price, int quant,string year) 
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
        

        public static DVD Find_DVD(DVD dvd) // Finds DVD Name From List As Checker
            {
                return DVDS.FirstOrDefault(d =>
                    d.Name.Equals(dvd.Name, StringComparison.OrdinalIgnoreCase)) ?? new DVD { Name = "Unknown", Genre = "N/A" }; ;
            }
        }
