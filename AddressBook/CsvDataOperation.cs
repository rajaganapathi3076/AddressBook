using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CsvDataOperation
    {

        
        public static void CsvDataSerialize(List<Contact> listofContact,string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                CsvWriter csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(listofContact);
                sw.Flush();
            } 
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }

        }
        public static List<Contact> CsvDataDeSerialize( string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                CsvReader csvReader= new CsvReader(sr, CultureInfo.InvariantCulture);
                List<Contact> res=csvReader.GetRecords<Contact>().ToList();

                foreach (Contact contact in res)
                {
                    Console.WriteLine(contact);
                }
                return res;
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }

        }
    }
}
