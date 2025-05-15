using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper;
using Library_Managment__System;
using static Inventory.Book;
using Microsoft.VisualBasic.Devices;
using System.Linq.Expressions;
using Inventory;
namespace UserNamespace
{
    
    public abstract class User
    {
        public static string Old_members_Fpath = "E:\\Git Repos\\Library-Management-System\\UsersDataBase.csv";
        public static string Admins_FBath = "E:\\Visual Studio Projects\\Library System\\UsersDataBase.csv";

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
        public virtual void Sign(string name, string phone,string department)
        {
            Name = name;
            department = "";
        }
        public virtual bool Log(string id, string password)
        {
            return false;
        }
    }

    public class Admin : User
    {
        // Encapsulation with properties
        public string ID { get; private set; }
        private string password;

        public Admin(string id, string password)
        {
            ID = id;
            this.password = password;
        }

        // Override Log method to verify credentials(pass/id)
        public override bool Log(string id, string password)
        {
            return ID == id && this.password == password;
        }
    }

    
        public class OldMember : User
        {
            private string phoneNumber = "";
            private string depart = "";
            public int TrustScore { get; private set; }
            public String Depart { get =>depart;private set=> depart= value; }
            public string PhoneNumber
            {
                get => phoneNumber;
                private set => phoneNumber = value;



                // Override Sign to check existing user

            }
        public OldMember(){}
        public OldMember(string name, string phone,string department)
        {
            this.Name = name;
            this.phoneNumber = phone;
            this.depart = department;
        }
        public static List<string> DepartList = new List<string>()
        {"Computer Engineering", "Architecture","Electrical", "Computer Science"
        };


            public static List<OldMember> ReadUsers()
            {
                try
                {
                    if (!File.Exists(Old_members_Fpath))
                    {
                        return new List<OldMember>();
                    }

                    using (var reader = new StreamReader(Old_members_Fpath))
                    using (var csv = new CsvReader(reader,
                        new CsvConfiguration(CultureInfo.InvariantCulture)
                        {
                            HasHeaderRecord = true,
                            MissingFieldFound = null,
                            BadDataFound = null
                        }))
                    {
                        csv.Context.RegisterClassMap<UserMap>();
                        return csv.GetRecords<OldMember>().ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading Users: {ex.Message}");
                    return new List<OldMember>();
                }
            }
        public static void WriteUsers(List<OldMember> Users)
        {
            try
            {
                using (var writer = new StreamWriter(Old_members_Fpath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    // Register the mapping class
                    csv.Context.RegisterClassMap<BookMap>();
                    csv.WriteRecords(Users);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to CSV: {ex.Message}");
            }
        }

        public static User SearchUser(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a Username");
                return new OldMember();
            }

            try
            {
                var Userslist = OldMember.ReadUsers();

                var foundUser = Userslist.FirstOrDefault(u =>
                    !string.IsNullOrEmpty(u.Name) &&
                    u.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

                if (foundUser == null)
                {
                    MessageBox.Show($"User '{searchTerm}' not found");
                    return new OldMember();
                }
                else return foundUser;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}");
                return new OldMember(); ;
            }
        }

        public static int SearchUser(List<OldMember> Oldmember, string searchTerm)
        {
            try
            {
                var Memberlist = Oldmember;
                var foundUser = Memberlist.FirstOrDefault(b =>
                    !string.IsNullOrEmpty(b.Name) &&
                    b.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

                int index = Memberlist.FindIndex(b =>
            !string.IsNullOrEmpty(b.Name) &&
            b.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

                if (foundUser == null)
                {
                    return -1;
                }
                else return index;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}");
                return -1;
            }
        }


        public static void Add_Users_csv(OldMember oldmember)
        {
            try
            {

                if (!File.Exists(Old_members_Fpath))
                {
                    File.WriteAllText(Old_members_Fpath, "Name,PhoneNumber,Depart\n");
                    MessageBox.Show("file Created ");
                }
                List<OldMember> mylist = OldMember.ReadUsers();
                int index = OldMember.SearchUser(mylist, oldmember.Name);
                if (index != -1)
                {
                    if (mylist[index].Name.ToLower() == oldmember.Name.ToLower())
                    {
                        MessageBox.Show("Username already taken");
                        return;
                    }
                }
                File.AppendAllText(Old_members_Fpath, $"{oldmember.Name.ToLower()},{oldmember.phoneNumber.ToLower()},{oldmember.depart}\n");
            }



            catch (Exception ex)
            {
                MessageBox.Show($"Error saving book: {ex.Message}");
            }
        }

        public sealed class UserMap : ClassMap<OldMember>
            {
                public UserMap()
                {
                    Map(m => m.Name).Name("Name");
                    Map(m => m.PhoneNumber).Name("Phone");
                    Map(m => m.Depart).Name("Depart");
                }
            }
        }

}


