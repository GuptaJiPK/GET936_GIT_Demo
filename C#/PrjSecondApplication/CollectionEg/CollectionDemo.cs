using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionEg
{
    class CollectionDemo
    {
        static void ArrayEg()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Capacity {0}",al.Capacity);
            al.Add(10);
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add("Devi");
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add(100.0f);
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add('a');
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add(20);
            Console.WriteLine("Capacity {0}", al.Capacity);
            foreach(var arraylist in al)
            {
                Console.WriteLine(arraylist);
            }
            Console.WriteLine("Count is{0}", al.Count);
            Console.WriteLine("index is {0}", al.IndexOf(20));
            Console.WriteLine("caapacity of {0}", al.Capacity);

            al.Remove("Devi");
            al.Remove(20);

            foreach(var arraylist in al)
            {
                Console.WriteLine("Capacity {0}", al.Capacity);
            }
            
            static void HashtableEg()
            {
                Hashtable ht = new Hashtable();
                ht.Add("N", "Networks");
                ht.Add("O", "Operating System");
                ht.Add("J", "Java");
                ht.Add("U", "Unix");

                Console.WriteLine(ht.Contains("O"));
                foreach(DictionaryEntry d in ht)
                {
                    Console.WriteLine(d.Key + " " + d.Value);
                }

                static void SortedListEg()
                {
                    SortedList s1 = new SortedList();
                    s1.Add("N", "Networks");
                    s1.Add("O", "Operating System");
                    s1.Add("J", "Java");
                    s1.Add("U", "Unix");
                    foreach (DictionaryEntry d in s1)
                    {
                        Console.WriteLine(d.Key + " " + d.Value);
                    }
                }

                static void Main()
                {
                    ArrayEg();
                    Console.WriteLine("Hash Table");
                    HashtableEg();
                    Console.WriteLine("Sorted List");
                    SortedListEg();
                }

            }
        }
        
    }
}
