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
    public class Student
    {
        private string stuName;

        private int stuID;

        public int gpa1 { get; set; }

        //Name set and get 

        public void SetName(string setName)
        {
            stuName = setName;
        }

        

        public string GetStuName()
        {
            return stuName;
        }


        // student id get/set with validation 
        public int GetStuID()
        {
            return stuID;
        }
      
        
        public void SetStuID(int setID)
        {
            if (setID > 000000)
                throw new Exception ("Number must be higher then 000000");
            if (setID < 999999)
                throw new Exception ("Number must be lower then 999999");
            else
            {
                stuID = setID;
            }

            stuID = setID;
        }



        public Student(string name, int id, int grade)
        {
            stuName = name;
            stuID = id;
            gpa1 = grade;
        }





        public Student() : this("none", 222222, 0) { }

        public Student(string name) : this(name, 222222, 0) { }

        
        
        
        //print state for testing and value sharing
        
        public void PrintState()
        {
            Console.WriteLine("Name:\t{0}", stuName);
            Console.WriteLine("ID:\t{0}", stuID);
            Console.WriteLine("GPA:\t{0}", gpa1);
        }



        

    }
}
