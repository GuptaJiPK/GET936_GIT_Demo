using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{ class Student
    {
        internal int rollNo { get; set; }
        internal string name { get; set; }
        internal string dateofbirth { get; set; }
        
    
        Student(int id,string name,string dateofbirth)
        {
            this.id = id;
            this.name = name;
            this.dateofbirth = dateofbirth;
        }
    }
    
    class Info(){
            public static void display(Student student)
    {
        Console.WriteLine("");
    }
}

class App
{
    public static void Scenario1()
    {
        student student1 = new student(1,"Mohan",Convert.ToDateTime("12/12/2019"));
        student student2 = new student(2, "Aayush", Convert.ToDateTime("13/11/2019"));
        student student3 = new student(3, "Ram", Convert.ToDateTime("14/10/2019"));

        Info info = new Info();
        info.display(student1);
        info.display(student2);
        info.display(student3);

    }

    public static void Scenario2()
    {
        StudentDB[] students = new StudentDB[3];
         student[0] = new Student(1, "Mohan", Convert.ToDateTime("12/12/2019"));
         student[1] = new Student(2, "Aayush", Convert.ToDateTime("13/11/2019"));
         student[2] = new Student(3, "Ram", Convert.ToDateTime("14/10/2019"));
        
    }
    public statuc void Scenario3()
    {
        Console.WriteLine("Enter number of students:");
        int n = Convert.ToInt32(Console.ReadLine());
        Student[] students = new Student[n];
        for(int i = 0; i < students.Length; i++)
        {
            Console.WriteLine("Enter roll no,name and DOB");
            int rollno = Convert.ToInt32(Console.ReadLine());
            String name = Console.ReadLine();
            DateTime date = DateTime.Parse(Console.ReadLine);
            students[i] = new Student(rollno, name, date);
        }
        foreach(StudentDB su in students)
        {
            Info.display(su);
        }
    }
}
    class StudentDB
    {
    }

