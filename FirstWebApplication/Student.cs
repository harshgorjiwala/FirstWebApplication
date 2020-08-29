using System;
namespace FirstWebApplication
{
    // student class added
    public class Student
    {
        public int ID { get; set; }

        public string StudentName { get; set; }

        public Student(int id,String name)
        {
            this.ID = id;
            this.StudentName = name;
        }

        public override string ToString() 
        {
            return "Student ID:" + ID + " Student Name:" + StudentName; 
        }
    }
}
