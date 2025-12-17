using Advanced04.HashTable;
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
           ////..Hashtable have 16 constructor 
            Hashtable PhoneNote = new Hashtable(new StringEqualityComparer())
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

            //foreach (string item in PhoneNote.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("...............");
            //// use int? to allow null values because value can be null
            //foreach (int? item in PhoneNote.Values)
            //{
            //    Console.WriteLine(item);
            //}
            #region Indexer of hashtable
            //Console.WriteLine(PhoneNote["George"]); // 555 return value by key
            //PhoneNote["George"] = 1; // to add or update value
            //var Result =  PhoneNote["George"];
            //Console.WriteLine($"The phone number for George is: {Result}");

            //foreach (DictionaryEntry item in PhoneNote)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //} 
            #endregion

            #region How To Use Add()
            // use Add() method is not save because if the key exists it will throw exception
            //PhoneNote.Add("George", 999); // throws exception because key exists
            //Use ContiansKey() => returns bool if the key is exists or not will return false 
            //bool isExisit = PhoneNote.ContainsKey("George"); // return true 
            //if (!isExisit)
            //{
            //    PhoneNote.Add("George", 010);
            //}


            //bool isExisit = PhoneNote.ContainsKey("AA"); // return true 
            //if (!isExisit)
            //{
            //    PhoneNote.Add("AA", 010);
            //}
            //Console.WriteLine(isExisit);
            //foreach (object item in PhoneNote)
            //{
            //    Console.WriteLine(item);
            //}

            #region Add() with Equals()

            //PhoneNote.Add("George", 999); // throws exception because key exists
            //PhoneNote.Add("george", 999); // will not throw exception because key not exists [case sensitive]
            //////.george = George but different in case use Equals() method to compare keys
            //////.Override Equals() method to make it case insensitive
            //foreach (var item in PhoneNote)
            //{
            //    Console.WriteLine(item);
            //}


            #region After Use Custom StringEqualityComparer
            ////.. use the overloading to take interface IEqualityComparer or any type inherit
            PhoneNote.Add("george", 999);
            foreach (var item in PhoneNote)
            {
                Console.WriteLine(item);
            }


            #endregion
            #endregion
            #endregion
            #endregion

            #endregion

            #endregion
        }
    }
}

