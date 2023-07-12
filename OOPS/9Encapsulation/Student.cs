using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Encapsulation
{
    public class Student
    {
        //property
        private int StudentID { get; set; }
        private string StudentName { get; set;}

        //cannot use constructor bcz we use private access specifier
        //use constructor after setting the getter and setter method 

        //getter and setter methods
        public int studentId
        {
            get
            {
                return StudentID;
            }
            set
            {
                StudentID = value;
            }
        }

        public string studentName
        {
            get { return StudentName; }
            set { StudentName = value; }
        }

        //constructor
        public Student()
        {
            
        }
        public Student(int StudentId, string StudentName)
        {
            studentId = StudentId;
            studentName = StudentName;  
        }

        //functions
        public void StudentDetails()
        {
            Console.WriteLine($" Student Id = {StudentID} and Student Name = {StudentName}");
        }
    }
}
