using System;
namespace FirstWebApplication
{
    public class Subject
    {
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public Subject(int id,string name)
        {
            this.ID = id;
            this.SubjectName = name;
        }

        public override string ToString()
        {
            return "Subject id:" + ID + " Subject Name:" + SubjectName;
        }
    }
}
