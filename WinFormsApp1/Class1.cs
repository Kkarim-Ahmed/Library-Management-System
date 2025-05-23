using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Managment__System;
using Microsoft.VisualBasic;
using CsvHelper.Configuration.Attributes;

namespace CSVClass
{
        public static class CsvFile<T> where T : Objects

        {
            public static List<T> Read(string filePath, ClassMap<T> map)
            {
                if (!File.Exists(filePath)) return new List<T>();
                using var reader = new StreamReader(filePath);
                using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true });
                csv.Context.RegisterClassMap(map);
                return csv.GetRecords<T>().ToList();

            }
            public static void Write(string filePath, List<T> Records, ClassMap<T> map)
            {
                using var writer = new StreamWriter(filePath);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.Context.RegisterClassMap(map);
                csv.WriteRecords(Records);
            }
            public static int Search(List<T> items, string searchTerm)
            {
                return items.FindIndex(i => !string.IsNullOrEmpty(i.Name) && i.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));
            }
        }

    }

       
    
