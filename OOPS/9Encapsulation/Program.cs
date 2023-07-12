namespace _9Encapsulation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student stuObj = new Student(101, "Nandhni");
            stuObj.StudentDetails();

            Student stuObj1 = new Student();
            stuObj1.studentId = 102;
            stuObj1.studentName = "Venkat";
            stuObj1.StudentDetails();
        }
    }
}