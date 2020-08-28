using System;
namespace FirstWebApplication
{
    // this is new class

    public class Class
    {
        public int ID { get; set; }

        public string ClassName { get; set; }

        public Student student1;

        public Subject Subject1;

        
        public Class(int i,string className) // polymorphism
        {
            this.ClassName = className;
            this.ID = i;

        }
        public Class(int id,Student st,Subject sb) // polymorphism
        {
            this.ID = id;
            this.student1 = st;
            this.Subject1 = sb;
        }

        public override string ToString()
        {
            return "Class Id: " + ID + "Student Name is " + student1.StudentName+ " Subject name is "+Subject1.SubjectName;
        }
    }
}
