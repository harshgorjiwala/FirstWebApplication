using System;
namespace FirstWebApplication
{
    public class Teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public int ID { get; set; }
        public string TeacherName { get; set; }

        public string Subject { get; set; }

        public Teacher(int id, string teacherName, string subject) 
        {
            this.ID = id;
            this.TeacherName = teacherName;
            this.Subject = subject;
        }

        
        public string details(int ID, string TeacherName) 
        {
            return "Teacher Id:" + ID + " Teacher Name: " + TeacherName; 
        }

        public string details(string Subject)        //Method Overloading  
        {
            return " Teacher Name: " + TeacherName + "is teaching " + Subject;
        }

        Teacher teacherpoly = new Teacher() ;
        Teacherpoly.details(10,"Harsh");
        Teacherpoly.details("Science");

 

    }
}
