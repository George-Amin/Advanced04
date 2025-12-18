using Advanced04.DictionaryHelper;
using Advanced04.EmployeeHelper;
using Advanced04.HashTable;
using System.Collections;
using System.Xml.Linq;

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
            //Hashtable PhoneNote = new Hashtable(new DictionaryHelper.StringEqualityComparer())
            //{
            //    ["George"] = 555,
            //    ["Ali"] = 1234,
            //    ["Veli"] = 5678,
            //    ["Ayse"] = null
            //};
            #endregion
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
            //PhoneNote.Add("george", 999);
            //foreach (var item in PhoneNote)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
            #endregion
            #endregion

            #endregion

            #endregion


            #region Dictionary<TKey , TValue>
            /* 
             Dictionary<string, int> PhoneNumbersDictionary = new Dictionary<string, int>()
                {
                    {
                        "George",555
                    },
                    {
                        "Ali",1234
                    },
                    {
                        "Veli",5678
                    },
                    {
                        "Ayse",2222
                    }

                };
            */
            //foreach (KeyValuePair<string, int> i in PhoneNumbersDictionary)
            //    Console.WriteLine(i);


            #region Indexer Dictionary 
            //// set value 
            //PhoneNumbersDictionary["George"] = 11;
            //// get value
            //Console.WriteLine(PhoneNumbersDictionary["George"]);

            ////TryGetValue => return boolean if key exists return true and output value by out parameter otherwise return false 
            //bool IsExists = PhoneNumbersDictionary.TryGetValue("george", out int value); //// value is default Data type if key not exists
            //Console.WriteLine(IsExists);//// false
            //Console.WriteLine(value); //// 0


            #endregion


            #region Adding New Element
            ////PhoneNumbersDictionary.Add("John", 3333); // if key exists will throw exception not safe
            ////TryAdd => return boolean if key added return true otherwise false   
            //// need add new item
            ////..if key exists will return false use ! to add new item
            //if (!PhoneNumbersDictionary.ContainsKey("SS"))
            //{
            //    PhoneNumbersDictionary.Add("SS" , 789);
            //}
            //Console.WriteLine(PhoneNumbersDictionary["SS"]);
            #region TryAdd()
            //PhoneNumbersDictionary.TryAdd("John", 3333); // if key exists will return false not safe
            //Console.WriteLine(PhoneNumbersDictionary["John"]);
            #endregion
            #endregion

            #region Dictionary Constructor ....

            #region use constructor that take the capacity...
            // use constructor that take the capacity...
            //Dictionary<string, int> PhoneNumbersDictionary = new Dictionary<string, int>(4);

            //Console.WriteLine(PhoneNumbersDictionary.Capacity);  
            #endregion

            #region  constructor that take the IEnumerable<KeyValuePair<TKey,TValue>>....
            // use constructor that take the IEnumerable<KeyValuePair<TKey,TValue>>....
            //Dictionary<string, int> PhoneNumbersDictionary = new Dictionary<string, int>();
            //KeyValuePair<string, int>[] arrPdoneNums = new KeyValuePair<string, int>[]
            //{
            //    new KeyValuePair<string, int>("George",555645),
            //    new KeyValuePair<string, int>("Ali",1234),
            //    new KeyValuePair<string, int>("Veli",5678),
            //    new KeyValuePair<string, int>("Ayse",2222)
            //};

            //PhoneNumbersDictionary = new Dictionary<string, int>(arrPdoneNums);

            //foreach (var item in PhoneNumbersDictionary)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}
            #endregion

            #region Dictionary Constructor that take IEqualityComparer.... 

            ////..take IEqualityComparer to compare keys..

            //KeyValuePair<string, int>[] ArrOfPhoneNote = 

            //{
            //    new KeyValuePair<string, int>("George",555645),
            //    new KeyValuePair<string, int>("Ali",1234),
            //    new KeyValuePair<string, int>("Veli",5678),
            //    new KeyValuePair<string, int>("Ayse",2222),
            //    //new KeyValuePair<string, int>("Ayse",2222) //// exception key duplicate
            //};

            //Dictionary<string, int> PhoneNumbersDictionary = new Dictionary<string, int>(ArrOfPhoneNote,new DictionaryHelper.StringEqualityComparer());

            //foreach (var item in PhoneNumbersDictionary)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}

            #endregion

            #endregion

            #endregion


            #region User Define Data Type  Dictionary Employee
            //Employee emp1 = new Employee(1, "George", 13213);
            //Employee emp2 = new Employee(10, "AA", 13213);
            //Employee emp3 = new Employee(20, "BB", 13213);
            //Dictionary<Employee, string> Emps = new Dictionary<Employee, string>()
            //{
            //    [emp1] = "one",
            //    [emp2] = "Two",
            //    [emp3] = "Three"
            //};
            //foreach(KeyValuePair<Employee , string> i in Emps)
            //{
            //    Console.WriteLine($"key:{i.Key} - Value: {i.Value}");
            //}

            ////Employee emp04 = new Employee(20, "BB", 13213);
            ////Emps.Add(emp04, "Four");
            ////valid because the Employee's hashcode is different    
            //foreach (KeyValuePair<Employee, string> i in Emps)
            //{
            //    Console.WriteLine($"key:{i.Key} - Value: {i.Value}");
            //}

            #region IEqualityComparer Constructor on dictionary
            //Employee emp4 = new Employee(20, "CC", 13213); // same Id as emp3 but different Name still valid unless override GetHashCode and Equals Use anther Overloud on Dictionary Constructor
            //Dictionary<Employee, string> Emps = new Dictionary<Employee, string>(new EmployeeIdIqualityComaparer())
            //{
            //    [emp1] = "one",
            //    [emp2] = "Two",
            //    [emp3] = "Three"
            //};

            //Emps.Add(emp4, "Four");

            //foreach (KeyValuePair<Employee, string> i in Emps)
            //{
            //    Console.WriteLine($"key:{i.Key} - Value: {i.Value}");
            //}

            #endregion
            #endregion



            #region Generic SortedDictionary<TKey,TValue>()
            //// it is a collections that stored the elements Key-Value pairs in sorted order based on Key [default ascending order]
            #region Default Constructor
            /* 
             SortedDictionary<string, int> PhoneNote = new SortedDictionary<string, int>()
                  {
                      ["George"] = 555,
                      ["Ali"] = 1234,
                      ["Veli"] = 5678,
                      ["Ayse"] = 2222
                  };

                  foreach (KeyValuePair<string, int> item in PhoneNote)
                  {
                      Console.WriteLine($"Key: {item.Key}:Value : {item.Value}");
                  }
            */
            /*
             Key: Ali:Value : 1234
            Key: Ayse:Value : 2222
            Key: George:Value : 555
            Key: Veli:Value : 5678
             */
            #endregion

            #region IComparer Constructor()
            /*
                        SortedDictionary<string, int> PhoneNote = new SortedDictionary<string, int>(new SortedDictionaryHelper.SortingDescComparer())  
                        {
                            ["George"] = 555,
                            ["Ali"] = 1234,
                            ["Veli"] = 5678,
                            ["Ayse"] = 2222
                        };

                        foreach (KeyValuePair<string, int> item in PhoneNote)
                        {
                            Console.WriteLine($"Key: {item.Key}:Value : {item.Value}");
                        }
            */

            Employee emp1 = new Employee(100, "George", 13213);
            Employee emp2 = new Employee(10, "AA", 13213);
            Employee emp3 = new Employee(20, "BB", 13213);
            /*

                        SortedDictionary<Employee, int> SortedDictianory = new SortedDictionary<Employee, int>()
                        {
                            [emp1] = 1,
                            [emp2] = 2,
                            [emp3] = 3
                        };
                        foreach (KeyValuePair<Employee, int> item in SortedDictianory)
                        {
                            Console.WriteLine($"Key: {item.Key}:Value : {item.Value}");
                        }
            */
            /*Unhandled exception. System.ArgumentException: At least one object must implement IComparable.*/
            //// in valid because Employee not implement IComparable interface
            //// because how can sort Employee without knowing the property to sort by WHAT?


            //// custom IComparer Constructor on Names  EmployeeNameComparer()



            //SortedDictionary<Employee, int> SortedDictionary = new SortedDictionary<Employee, int>(new EmployeeNameComparer())
            //{
            //    [emp1] = 1,
            //    [emp2] = 2,
            //    [emp3] = 3
            //};
            //foreach (KeyValuePair<Employee, int> item in SortedDictionary)
            //{
            //    Console.WriteLine($"Key: {item.Key}:Value : {item.Value}");
            //}

            #endregion




            #endregion



            #region SortedList<TKey, TValue>()

            //SortedList<string, int> PhoneNote = new SortedList<string, int>()
            //{
            //    {"Alice", 90},
            //    {"Bob", 85},
            //    {"George" ,55},
            //    {"Charlie", 92}
            //};

            //PhoneNote.GetKeyAtIndex(2); // "George"
            //PhoneNote.GetValueAtIndex(2); // 55


            /*  foreach (KeyValuePair<string, int> item in PhoneNote)
              {
                  Console.WriteLine($"Key: {item.Key}:Value : {item.Value}");
              }*/



            /*          for (int i = 0; i < PhoneNote.Count; i++)
                        {
                            Console.WriteLine(PhoneNote[i]);// invalid because there is no indexer with int
                        }*/

            #endregion



            #region Generic HashSet<T>
            //// it is a collection that store unique elements only no duplicate allowed and no indexer unordered
            //// and provide high performance for searching elements Lookups
            //HashSet<int> Elements = new HashSet<int>()
            //{
            //    1,1,1,2,2,2,3,3,3,4,4,4
            //};
            /*
                    1
                    2
                    3
                    4
            Remove Duplicates
             */
            HashSet<string> Elements = new HashSet<string>();
            //{
            //    "George","George" ,"Amin","Amin"
            //};
            Elements.Add("George");
            Elements.Add("Amin");
            Elements.Add("Shokry");
            Elements.Add("Aziz");
            Elements.Add("Amin");// not stored
            Elements.Add("amin");// not stored
            foreach (var item in Elements) Console.Write(item + " "); // George Amin

            #endregion



        }
    }
}

