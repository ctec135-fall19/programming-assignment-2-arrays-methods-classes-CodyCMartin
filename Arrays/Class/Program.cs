using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating student object with default values

            Student c = new Student();
            Console.WriteLine("Default Values");
            c.PrintState();
            Console.WriteLine();

            //creating student object 

            Student c2 = new Student("Cody Martin", 232323, 3);
            Console.WriteLine("Student Object");
            c2.PrintState();

            //testing out ID limitations

            
            




        }
    }
}
