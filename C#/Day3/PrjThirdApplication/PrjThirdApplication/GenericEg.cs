using System;
using System.Collections.Generic;
using System.Text;

namespace PrjThirdApplication
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }

        internal Person(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
    }

   
    class GenericEg
    {
        static void ListEg()
        {   //List is TypeSafe

            List<string> fruits = new List<string>();
            //Add
            fruits.Add("Mango");
            fruits.Add("Apple");
            fruits.Add("Orange");
            //Insert
            fruits.Insert(1, "Pineapple");
            //Remove
            fruits.RemoveAt(3);
            //fruits.add(10)    ----->erro since Lists are typesafe

            List<string> Vegetabes = new List<string>();
            //Add
            Vegetabes.Add("Carrot");
            Vegetabes.Add("Beetroot");
            Vegetabes.Add("Potato");
            //Adding a list into another list
            Vegetabes.AddRange(fruits);

            //For displaying

            foreach(var list in fruits)
            {
                Console.WriteLine("Fruits:{0}",list);
            }

            Console.WriteLine("Vegetables");

            foreach (var list in Vegetabes)
            {
                Console.WriteLine("Vegetables:{0}",list);
            }
        }

        static void DictionaryEg()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            //Adding
            dt.Add(1, "Java");
            dt.Add(2, "Networks");
            dt.Add(3, "AI");

            //Displaying
            foreach(KeyValuePair<int,string> kp in dt)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }
        }

        static void StackEg()
        {
            //Push, Pop, Peek, Contains, Clear---------> Different methods of stack

            Stack<int> st = new Stack<int>();
            //Push
            st.Push(40);
            st.Push(10);
            st.Push(20);
            st.Push(30);

            //Displaying

            foreach(var stack in st)
            {
                Console.WriteLine(stack); //-------O/P-->30,20,10,40
            }

            //Pop
            st.Pop();

            Console.WriteLine("After 1 Pop");

            foreach (var stack in st)
            {
                Console.WriteLine(stack); //-------O/P-->20,10,40
            }

            //Peek
            Console.WriteLine("Peek:{0}",st.Peek());


        }

        //SortedList 
        static void SortedListEg()
        {
            SortedList<int, string> sl = new SortedList<int, string>();
           //Add
            sl.Add(1, "sortedItem 2");
            sl.Add(3, "sortedItem 1");
            sl.Add(4, "sortedItem 3");
            sl.Add(2, "sortedItem 4");

            //Display
            foreach (KeyValuePair<int, string> kp in sl)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }

        }
        //Queue

        static void QueueEg()
        {
            Queue<int> q = new Queue<int>();
            //Enque or Adding
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);

            //Displaying
            foreach (var queue in q)
            {
                Console.WriteLine(queue); //-------O/P-->10,20,30,40
            }

            //Dequeue or Deleting

            q.Dequeue();
            Console.WriteLine("------------------");
            Console.WriteLine("After Dequeue");
            //Afetr deleting
            foreach (var queue in q)
            {
                Console.WriteLine(queue); //-------O/P-->20,30,40
            }
           /*
            *       use queue/stack/and every other ith (.) to know other methods of it
            *
            */

        }
        static void Main()
        {
            ListEg();
            Console.WriteLine("Personal Details");
            Console.WriteLine("------------------");

            List<Person> person = new List<Person>();

            person.Add(new Person(1, "SAI", "Bangalore"));
            person.Add(new Person(2, "SRI", "Orrissa"));
            person.Add(new Person(3, "RAM", "Gwalior"));

            foreach(Person p in person)
            {
                Console.WriteLine("id:{0} || name:{1} || city:{2}", p.id, p.name, p.city);
            }
            Console.WriteLine("------------------");
            DictionaryEg();

            Console.WriteLine("------------------");
            StackEg();
            Console.WriteLine("------------------");
            SortedListEg();
            Console.WriteLine("------------------");
            QueueEg();
        }
    }
}
