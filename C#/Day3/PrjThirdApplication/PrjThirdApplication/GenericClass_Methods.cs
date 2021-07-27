using System;
using System.Collections.Generic;
using System.Text;

namespace PrjThirdApplication
{
    //Generic class

    class Sample<T>
    {
        T Name;
        T City;

        internal Sample(T Name, T City)
        {
            this.Name = Name;
            this.City = City;
        }
        //Normal Method

        internal void Add(int x,int y)
        {
            Console.WriteLine("Additiono id: {0}", (x + y));
        }

        //Generic Method
        //<T>

        internal void Swap<T>(T x , T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("X is {0} || Y is {1}", x, y);
        }

    }

    /*Generic Constraint
     *where T:struct  //value type
     *where T: class //reference type
     *where T: new //efault parameter comstaint
     *where T:<interface name>
     */

    class Student<T> where T : struct
    {

    }
    class GenericClass_Methods
    {
        static void Main()
        {
            Sample<string> sample = new Sample<string>("Anu","Chennai");
            sample.Swap<int>(6, 8);
            sample.Swap<string>("Good", "Morning");

            //Struct Constarint
            //error becaise student class will accept only struct value(value type){---->value means numbers thing and all like int,float,double kinda}
            //student<string> student=new Student<string>();

            Student<int> student1 = new Student<int>();
        }
    }
}
