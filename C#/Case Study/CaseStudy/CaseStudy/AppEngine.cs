using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    interface IAppEngine
    {
        public void Introduce(Courses course);
        public void Register(StudentDB student);
        public List<StudentDB> ListOfStudents();
        public void Enroll(StudentDB student, Courses course);
        public List<Enroll> ListOfEnrollments();
    }

    class InMemoryAppEngine : IAppEngine
    {
        List<StudentDB> Students = new List<StudentDB>();
        List<Enroll> Enrollments = new List<Enroll>();

        public void Introduce(Courses course)
        {
            Console.WriteLine(course.ID + ' ' + course.Name + ' '
                + course.Duration + ' ' + course.Fees);
        }
        public void Register(StudentDB student)
        {
            string?[] phonenumbers = new string?[2];
            Console.WriteLine("Enter the Id: ");
            student.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name: ");
            student.name = Console.ReadLine();
            Console.WriteLine("Enter the Date in dd/mm/yyyy fromat: ");
            student.dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter your first phone number:");
            phonenumbers[0] = Console.ReadLine();
            Console.WriteLine("Enter your second phone number:");
            phonenumbers[1] = Console.ReadLine();
            student.PhoneNumbers = phonenumbers;
            //Storing the Students in <students LIST>
            Students.Add(student);
        }

        
    }
}
