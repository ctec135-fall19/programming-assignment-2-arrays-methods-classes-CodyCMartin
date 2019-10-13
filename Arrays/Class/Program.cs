/*
Author:  Cody Martin
Date: 10/11/19
CTEC 135: Microsoft Software Development with C#
<Module 3, Programming Assignment 2 , Problem 3 >
 classes
*/


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

            //testing setname method 

            c.SetName("Just Cody");
            Console.WriteLine("set name is: {0}",c.GetStuName());
            Console.WriteLine();


            //creating student object with specified values

            Student c2 = new Student("Cody Martin", 232323, 3);
            Console.WriteLine("Student Object");
            c2.PrintState();
            Console.WriteLine();

            //testing out ID set/get

            Student c3 = new Student();
            
            
            c3.PrintState();

            c3.GetStuID();

            Console.WriteLine(c3.GetStuID());
            Console.WriteLine();
           


            //exception testing
           try 
            {
                c3.SetStuID(000000000);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();



            

            
            




        }
    }
}
