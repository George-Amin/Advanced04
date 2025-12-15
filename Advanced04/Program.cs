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
            Hashtable PhoneNote = new Hashtable() { {"George", 555 }, {"Ali", 1234 }, {"Veli", 5678 }, {"Ayse", null} };
            #endregion

            #endregion

            #endregion
        }
    }
}
