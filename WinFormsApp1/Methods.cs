using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using CsvHelper.Configuration.Attributes;
using Library_Managment__System;

//namespace CSVClass
namespace Library_Managment__System
{
    public static class CsvFile<T> where T : Objects // Delcaring Generic Class For Objects Interface

    {
        public static List<T> Read(string filePath, ClassMap<T> map) // Declaring Generic Method To Read CSV File
        {
            if (!File.Exists(filePath)) return new List<T>(); // Checking If No File Is Created Returns Empty List If Not
            using var reader = new StreamReader(filePath); // Starts Data Stream Of CSV Files
            // Reads The Data Stream Created
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true }); 
            csv.Context.RegisterClassMap(map); // Using Map Given By Parameters
            return csv.GetRecords<T>().ToList(); // Returns List For Use In The Program

        }
        public static void Write(string filePath, List<T> Records, ClassMap<T> map) // Declaring Generic Method For Reading CSV File
        {
            using var writer = new StreamWriter(filePath); // Starts Data Stream For CSV File
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture); // Edits Data Files Using CSV Helper Library
            csv.Context.RegisterClassMap(map); // Uses Map Given By Parameters
            csv.WriteRecords(Records); // Writes List To CSV Files
        }
        public static int Search(List<T> items, string searchTerm) // Searches The Index In A List By Inherited Instance Name
        {
            // Compares Name And Returns Index In List
            return items.FindIndex(i => !string.IsNullOrEmpty(i.Name) && i.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));
        }
    }

}


