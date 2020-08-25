using System;
namespace FirstWebApplication
{
    public class Teacher
    {
<<<<<<< HEAD
        public int id { get; set; }
        public string name { get; set; }
=======
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
>>>>>>> 0a7e1fd52cda3092b8729646c30af81617b932d7
    }
}
