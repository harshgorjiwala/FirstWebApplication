using System;
namespace FirstWebApplication
{
    public class Teacher
    {
        public int ID { get; set; }
        public String TeacherName { get; set; }

        public Teacher(int id,String TeacherName) 
        {
            this.ID = id;
            this.TeacherName = TeacherName;
        }

        public String toString() 
        {
            return "Teacher Id:" + ID + " Teacher Name: " + TeacherName; 
        }
    }
}
