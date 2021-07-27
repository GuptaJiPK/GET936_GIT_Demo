using System;

namespace PrjSecondApplication
{
    enum feedback
    {
        excellent,verygood,good,bad
    };

    //Base class or Parent Class
   class Department
    {
        //protected is used with the class and only in derived class
        protected int Did { get; set; }
        protected string Dname { get; set; }
        protected string City { get; set; }

        internal Department(int Did, string Dname, string City)
        {
            Console.WriteLine("Department Constructor");
            this.Did = Did;
            this.Dname = Dname;
            this.City = City;
        }
        protected internal void DisplayDepartmentInfo()
        {
            Console.WriteLine("Did:{0},Dname{1}",Did,Dname);
        }

        ~Department()
        {
            Console.WriteLine("Department Destructor");
        }
    }

    //singel inheritance
    //child or derived class employee

    class Employee : Department
    {
        internal static string CompanyName = "LTI";
        internal int Eid { get; set; }
        internal String Name { get; set; }
        internal string City = "Pune";

        internal Employee(int Eid, string Name, int Did, String Dname, string City) : base(Did, Dname,City)
        {
            Console.WriteLine("Employee Constructor");
            this.Eid = Eid;
            this.Name = Name; 
        }
        internal void DisplayEmployeeinfo()
        {
            DisplayDepartmentInfo();
            Console.WriteLine("Department city is:{0}", base.City);
            Console.WriteLine("Eid:{0} || Ename: {1} || feedback:{2}",Eid,Name,(int)feedback.excellent);
            Console.WriteLine("Employee city is:{0}",City);
        }
        ~Employee()
        {
            Console.WriteLine("Employee Destructor");
        }
    }
    class PartTimeEmployee : Employee
    {
        internal int hoursofwork { get; set; }
        internal int salary { get; set; }
        internal PartTimeEmployee(int Eid, string Name, int Did, String Dname, string City, int hoursofwork, int salary):base(Eid,Name,Did,Dname,City)
        {
            this.hoursofwork = hoursofwork;
            this.salary = salary;
        }
        internal int MonthlySalary()
        {
            int Payment = hoursofwork * 30 * salary;
            return Payment;
        }

        ~PartTimeEmployee()
        {
            Console.WriteLine("PartTime Employee Destructor");
        }
    }

    class MultilevelInheritance
    {
        static void Main()
        {
            //Single Inheritance
            /* Employee employee = new Employee(1001, "SAI", 101, "HR", "Madurai");
             employee.DisplayEmployeeinfo();*/

            //error ----> Since it is protected
            //employee.DisplayDepartmentInfo();

            //Multiple Level Inheritance

            PartTimeEmployee pt = new PartTimeEmployee(1001, "SAI", 101, "HR", "Madurai",67,200);
            pt.DisplayEmployeeinfo();
            Console.WriteLine("Monthly Slary is:{0}", pt.MonthlySalary());

            GC.Collect();
        }
    }
}
