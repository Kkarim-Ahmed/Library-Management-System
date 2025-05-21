using CsvHelper.Configuration;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
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
    }

       public class Admins : User,Objects
    {
        // Encapsulation with properties
        public string ID { get;  set; }
        public string Password { get; private set; }
        public Admins(string id, string password)
        {
            this.ID = id;
            this.Password = password;
        }
    }

    public class Members : User, Objects // Member Class Inheriting From Objects Interface For Csv
    {
        public static String M_Path = "D:\\Programing\\GitHub Repos\\Library-Management-System\\Members.CSV"; // CSV File Path
        public static List<Members> Memberlist = new List<Members>(); // For Reading CSV Member list
        public string PhoneNumber { get; set; }
        public string Depart { get; set; }
        public Members() {
            this.Name = "";
            this.Depart = "";
            this.PhoneNumber = "";
        }

        public Members(string Name, string PhoneNumber, string depart) // Custom Constructor
        {
            this.PhoneNumber = PhoneNumber;
            this.Depart = depart;
            this.Name = Name;
        }

        public static void Add_Member(Members nmember) // Function To Add Members To The Member List
        {
            // To Check If Member Username Exists
            int index = CsvFile<Members>.Search(Members.Memberlist, nmember.Name);
            if (index != -1)
            {
                MessageBox.Show("Name Taken ");
            }
            // Add Member If Username Is Not Found
            else
            {
                Memberlist.Add(
                    // Calling Custom Constructor
                    new Members
                    {
                        Name = nmember.Name,
                        PhoneNumber = nmember.PhoneNumber,
                        Depart = nmember.Depart
                    });
                MessageBox.Show($"Added new Member '{nmember.Name}' to the member list");
            }
            // Writing New Member To Member List
            CsvFile<Members>.Write(M_Path, Memberlist, new Members.MemberMap());
        }

        // Member Map For CSV Mapping
        public class MemberMap : ClassMap<Members> 
        {
            public MemberMap()
            {
                Map(m => m.Name).Name("Name");
                Map(m => m.PhoneNumber).Name("PhoneNumber");
                Map(m => m.Depart).Name("Department");
            }
        }
    }
    public class Borrow : Inventory,Objects // Borrow Class Inheriting From Objects Interface
    {
        // Path For Borrowed Items CSV File
        public static string Borrow_Path = "D:\\Programing\\GitHub Repos\\Library-Management-System\\Borrowed.CSV"; 
        public string Itemname { get; set; }
        public string Itemtype { get; set; }
        public string Borrowdate{ get; set; }
        public string Duedate { get; set; }

        public static List<Borrow> Borrowedlist = new List<Borrow>(); // Borrowed Items List

        //Overriding Default Constructor
        public Borrow() { 
            this.Name= "";
            this.Itemname= "";
            this.Borrowdate= "";
            this.Itemtype = "";
            this.Duedate = "";
            }

        // Custom Constructor
        public Borrow(string username, string itemname, string itemtype,string borrowdate)
        {
            this.Name= username;
            this.Itemname= itemname;
            this.Itemtype = itemtype;
            this.Borrowdate= borrowdate;
            this.Duedate = borrowdate;
            this.Duedate = "";

        }

        // List To Track Borrowed Items

        // Borrowlist Map For CSV Mapping
        public class Borrowedmap : ClassMap<Borrow>
        {
            public Borrowedmap() {
                Map(m => m.Name).Name("Name");
                Map(m => m.Itemname).Name("Item Name");
                Map(m => m.Itemtype).Name("Item Type");
                Map(m => m.Borrowdate).Name("Date");
            }
        }
        public static List<Borrow> FindBorrowed(string name) // Searches For Borrowed Books In The List
        {
            var foundlist = Borrowedlist
            .Where(r => r.Name == name)
            .Select(r => r)
            .ToList(); ;
            return foundlist;
        }
        public static int SearchItemName(List<Borrow> list,string itemname) //Finds The Index Of The Searched Item
        {
            return list.FindIndex(i => !string.IsNullOrEmpty(i.Itemname) && i.Itemname.Equals(itemname, StringComparison.OrdinalIgnoreCase));

        }
        public void Borrowadd(Borrow borrow) // Adds Borrowed Items To CSV
            {
            Borrowedlist = CsvFile<Borrow>.Read(Borrow_Path, new Borrowedmap());
            Borrowedlist.Add(borrow);
            CsvFile<Borrow>.Write(Borrow_Path, Borrowedlist, new Borrowedmap());
        }
    }
}