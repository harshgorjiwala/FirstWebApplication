using System;
namespace FirstWebApplication
{
    // student class added
    public class Student
    {
        public int ID { get; set; }

        public String StudentName { get; set; }

        public Student(int id,String name)
        {
            this.ID = id;
            this.StudentName = name;
        }

        public String toString() 
        {
            return "Student ID:" + ID + " Student Name:" + StudentName; 
        }
    }
}
