using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class BinaryOperation

    {
        public static void BinarySerialization(List<Contact> list, string path)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                binaryFormatter.Serialize(stream, list);


            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public static void BinaryDeSerialization( string path)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream stream = new FileStream(path, FileMode.Open);
                List<Contact> list=(List<Contact>)binaryFormatter.Deserialize(stream);

                foreach(Contact contact in list) 
                {
                    Console.WriteLine(contact);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


    }
}
