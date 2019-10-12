using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Student
    {
        private string stuName;

        public string Name
        {
            get { return stuName; }
            set { stuName = value; }
        }

        private int stuID;

        public int ID
        {
            get { return stuID; }
            set
            {
                if (value <= 999999)
                {
                    if (value >= 111111)
                        value = stuID;
                }
                else
                {
                    Console.WriteLine("Pick another number");
                }


            }

        }
        public int gpa1 { get; set; }

        public Student(string name, int id, int grade)
        {
            stuName = name;
            stuID = id;
            gpa1 = grade;
        }

        public Student() : this("none", 222222, 0) { }

        public Student(string name) : this(name, 222222, 0) { }

        public void PrintState()
        {
            Console.WriteLine("Name:\t{0}", stuName);
            Console.WriteLine("Name:\t{0}", stuID);
            Console.WriteLine("Name:\t{0}", gpa1);
        }



        

    }
}
