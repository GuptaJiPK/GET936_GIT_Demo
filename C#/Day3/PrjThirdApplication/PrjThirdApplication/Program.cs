using System;
using System.Linq;
using System.Collections.Generic;

namespace PrjThirdApplication
{
    /*Query syntax
        from <raange variable> in ienumerable<T> or iquerable<T> collection
        standard query operators
        select or group by operatoor <result formation>*/

    class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        internal Student(int Rollno,string Name,string City,String Gender,int Age)
        {
            this.Rollno = Rollno;
            this.Name = Name;
            this.City = City;
            this.Gender = Gender;
            this.Age = Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] book = { "Engish", "Tamil", "Maths", "Science" };
           /* LINQ: Query Synatx
                display all books*/
            var result = from b in book
                         select b;
            foreach (var bname in result)
            {
                Console.WriteLine(bname);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("display th book name that contains 'a'");

            //dispaly the book name that contains a
            //Query Syntax
            var r = from bookname in book
                    where bookname.Contains('a')
                    select bookname;
            //Method Syntax
            var m1 = book.Where(s => s.Contains('a'));
            foreach (var bname in m1)
            {
                Console.WriteLine(bname);
            }
            Console.WriteLine("-------------------");
            foreach (var bname in r)
            {
                Console.WriteLine(bname);
            }
            int[] Marks = { 90, 78, 67, 99, 100 };
            Console.WriteLine("Minimum Marks:{0}", Marks.Min());
            Console.WriteLine("Maximum Marks:{0}", Marks.Max());

            //marks btw 70-100

            var r1 = from m in Marks
                     where m > 70 && m <= 100
                     select m;

            //Method Syntax
            var m2 = Marks.Where(mark => mark > 70 && mark <= 100);
            foreach (var marks in m2)
            {
                Console.WriteLine(marks);
            }
            Console.WriteLine("---------------------");
            foreach (var marks in r1)
            {
                Console.WriteLine(marks);
            }


            //count no of marks btw 70 and 100

            var r2 = (from m in Marks
                      where m > 70 && m <= 100
                      select m).Count();
            Console.WriteLine("No of marks btw 70 and 100 :{0}", r2);

            List<Student> stu = new List<Student>()
            {
                new Student(1001,"Janak","trichy","female",24),
                new Student(1002, "Ravi", "Chennai", "male",20),
                new Student(1003, "Balu", "Madurai", "male",22),
                new Student(1004, "ABI", "Salem", "female",21),
            
            };

            //Displa max age of students
            var student = stu.Max(stud => stud.Age);
            foreach(var s_age in stu)
            {
                Console.WriteLine(s_age);
            }
            Console.WriteLine("---------------------");
            //Dispaly name and city whrer city is chennai

            var stucity = from s in stu
                          where s.City.Equals("Chennai")
                          select new { s.Name, s.City };

            Console.WriteLine("----------------------------");
            Console.WriteLine("Dispaly name and city whrer city is chennai");

            foreach(var st in stucity)
            {
                Console.WriteLine(st.Name + " " + st.City);
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("order the student info based on gender");
            //order by
            //order the student info based on the gender

            var stugender = from s in stu
                            orderby s.Gender, s.Name
                            select s;

            foreach(var st in stugender)
            {
                Console.WriteLine(st.Name + " " + st.City + " " + st.Gender);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine(" No of males and females");
            //Group by
            //No of males and females

            var stumf = from s in stu
                        group s by s.Gender;

            foreach(var s in stumf)
            {
                Console.WriteLine(s.Key + " " + s.Count());
            }

        }
    }
}
