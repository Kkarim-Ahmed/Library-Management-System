//using Inventory;
using CsvHelper.Configuration;
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace Library_Managment__System { 

    
    public class User
    {


        // Encapsulated properties
        private string name="";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual void Sign(string name)
        {
            Name = name;
        }

        // Overloaded method
       

        public virtual bool Log(string id, string password)
        {
            return false;
        }
    }

       public class Admins : User,Objects
    {
        public string Name { get; set; }
        public static List<Admins> Adminss = new List<Admins>();
        

        // Encapsulation with properties
        public string ID { get;  set; }
        private string password;
        public string Password { get; private set; }

        public Admins(string id, string password)
        {
            this.ID = id;
            this.password = password;
        }

        // Override Log method to verify credentials(pass/id)
        public override bool Log(string id, string password)
        {
            return ID == id && this.password == password;
        }
    }

        public class Members : User,Objects
        {
        public static String M_Path = "D:\\semester4\\oop\\Library-Management-System-main\\Members.csv";
        public static List<Members> Memberlist = new List<Members>();



        public List<Book> Borrowed_books = new List<Book>();
        public List<DVD> Borrowed_DVDS = new List<DVD>();

        public string PhoneNumber { get; set; }
        private string depart = "";
        public string Borrowed_Books = "";
        public int TrustScore { get; private set; }
        public String Depart { get; set; }

        public Members() { }
        public Members (string Name, string PhoneNumber,string depart)
        {
            this.PhoneNumber=PhoneNumber;
            this.Depart=depart;
            this.Name=Name;
            TrustScore = 0;
        }
        public static void Add_Member(Members nmember)
        {
             Members existingmember = Find_member(nmember.Name);
            if (existingmember != null)
            {
                MessageBox.Show("Name Taken ");
            }
            else
            {
                Memberlist.Add(
                    new Members{
                    Name = nmember.Name,
                    PhoneNumber = nmember.PhoneNumber,
                    depart = nmember.Depart
                });
                MessageBox.Show($"Added new Member '{nmember.Name}' to the member list");
            }
            CsvFile<Members>.Write(M_Path, Memberlist, new Members.MemberMap());

        }
        public static  Members Find_member(string nmember)
        {
            Memberlist = CsvFile<Members>.Read(M_Path, new Members.MemberMap());
            if (nmember == null)
            {
                MessageBox.Show("Error: Book is null");
                return null;
            }

            if (string.IsNullOrWhiteSpace(nmember))
            {
                MessageBox.Show("Error: Book name cannot be empty");
                return null;
            }

            // Check for existing book (case-insensitive comparison)
            Members existingmember = Memberlist.FirstOrDefault(b =>
                b.Name.Equals(nmember, StringComparison.OrdinalIgnoreCase));

            return existingmember;
        }
        public class MemberMap : ClassMap<Members>
        {
            public MemberMap()
            {
                Map(m => m.Name).Name("Name");
                Map(m => m.PhoneNumber).Name("PhoneNumber");
                Map(m => m.depart).Name("Department");
                Map(m => m.TrustScore).Name("trustScore");
                Map(m => m.Borrowed_Books).Name("Borrowed Books");
            }
        }
    }
    }


