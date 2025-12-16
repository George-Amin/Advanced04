using System.Collections;

namespace Advanced04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hash Table
            //.This code demonstrates the use of a hash table in C#.
            //.stored key-value pairs
            //.it is array of buckets [Hash_coll , Key , Value]
            //.the key must be unique
            //.the key can not be null but value can be null
            //.it is not type safe
            //.Most Common Actions => Add - Removes - Clear - Contains - Count 

            #region Non Generic Hash Table  
            // will Use the namespace System.Collections
            //Hashtable PhoneNote = new Hashtable();
            #region old syntax
            //PhoneNote.Add("Ali", "555-1234");
            //PhoneNote.Add("Veli", "555-5678");
            //PhoneNote.Add("Ayse", null); // Value can be null
            //                             //PhoneNote.Add(null, "555-1234"); ////exception key can not be null Value can be null 
            //                             //PhoneNote.Add("Ali", "555-1234"); ////Hashtable does not allow duplicate keys


            #endregion

            #region Sugar syntax
            //Hashtable PhoneNote = new Hashtable() { { "George", 555 }, { "Ali", 1234 }, { "Veli", 5678 }, { "Ayse", null } };
            Hashtable PhoneNote = new()
            {
                ["George"] = 555,
                ["Ali"] = 1234,
                ["Veli"] = 5678,
                ["Ayse"] = null
            };
            // Every item in hashtable returns DictionaryEntry

                //foreach (/*DictionaryEntry*/ /*var*/  object item in PhoneNote) // Change back to DictionaryEntry
                //{
                //// object can not access Key and Value properties
                //Console.WriteLine(item);
                ////Console.WriteLine($"{item.Key}{item.value}");
                //}
            // there is no indexer in hashtable and not sorted but if run again the order may change

            foreach (string item in PhoneNote.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("...............");
            // use int? to allow null values because value can be null
            foreach (int? item in PhoneNote.Values)
            {
                Console.WriteLine(item);
            }
            #endregion

            #endregion

            #endregion
        }
    }
}
