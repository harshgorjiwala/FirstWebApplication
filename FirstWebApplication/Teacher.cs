using System;
namespace FirstWebApplication
{
    public class Teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public int ID { get; set; }
        public string TeacherName { get; set; }

        public string Position { get; set; }

        public Teacher(int id, string TeacherName, string Position) 
        {
            this.ID = id;
            this.TeacherName = TeacherName;
            this.Position = Position;
        }
       
        public string details(int ID, string TeacherName) 
        {
            return "Teacher Id:" + ID + " Teacher Name: " + TeacherName; 
        }

        public string details(string Position)        //Method Overloading  
        {
            return " Teacher Name: " + TeacherName + "works as a " + Position;
        }

        Teacher obj = new teacherpoly;
        Teacherpoly.details(10,"Harsh");
        Teacherpoly.details("Science");

 

    }
}
