using System;
namespace FirstWebApplication
{
    public class Subject
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public Subject(int id,String name)
        {
            this.ID = id;
            this.SubjectName = name;
        }

        public String toString()
        {
            return "Subject id:" + ID + " Subject Name:" + SubjectName;
        }
    }
}
