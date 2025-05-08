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
namespace Library_Managment__System { 

    
    public class User
    {
        public static string Old_members_Fpath = "E:\\Visual Studio Projects\\Library System\\UsersDataBase.csv";
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

    public class NewMember : User
    {
        private string phoneNumber="";
        public string depart="";
        public int TrustScore { get; private set; }//auto implemented property

        public string PhoneNumber
        {
            get => phoneNumber;
            private set => phoneNumber = value;
        }
        public NewMember (string name , string phoneNumber,string department)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.depart= department;
        }
        // Override Sign to register user
        public override void Sign(string name, string phone,string department)
        {
            base.Sign(name, phone,department);
            PhoneNumber = phone;
            this.depart = department;
            TrustScore = 0;
            if (!File.Exists(Old_members_Fpath))
            {
                File.WriteAllText(Old_members_Fpath,$"Name,Phone,TrustScore,Depart\n");
            }
               File.AppendAllText(Old_members_Fpath, $"{name},{phone},{TrustScore},{department}\n");


        }

        public class oldMember : User
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


            public static List<User> Readusers()
            {
                try
                {
                    if (!File.Exists(Old_members_Fpath))
                    {
                        return new List<User>();
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
                        return csv.GetRecords<User>().ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading Users: {ex.Message}");
                    return new List<User>();
                }
            }
            public sealed class UserMap : ClassMap<oldMember>
            {
                public UserMap()
                {
                    Map(m => m.Name).Name("Name");
                    Map(m => m.PhoneNumber).Name("Phone");
                    Map(m => m.TrustScore).Name("TrustScore");
                    Map(m => m.Depart).Name("Depart");
                }
            }
        }

    }
}
