using CsvHelper;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class JsonDataOperation
    {

        public static void JsonDataSerializer(string JsonFilePath, List<Contact>list)
        {
            

            string json = JsonConvert.SerializeObject(list,Formatting.Indented);
            System.IO.File.WriteAllText(JsonFilePath, json);

        }
            
    }
}
