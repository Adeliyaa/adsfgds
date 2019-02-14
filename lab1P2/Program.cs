using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class student
    {
        public string name; //the variable of student class
        //public means it can work in another functions and can be used in outside this class
        public int id;
        public int year;

        public student() 
            //empty constructor which dont have a parameter, so here we dont give them parameters, user will give the value 
        {
            name = Console.ReadLine(); // read the var name 
            id = int.Parse(Console.ReadLine()); // read and conver to int the var int 
            y(); // go to the function y()
        }

        public student(string name, int id)
            //constructor which have the parameters
        {
            this.name = name; // it takes the value in public name 
            this.id = id; // takes the value from public id 
            y();
        }

        public void y()
        {
            year = int.Parse(Console.ReadLine()) + 1; // increment the value of the year 
            Console.Write(year + " "); //display year 
        }

        public override string ToString()
        {
            return name + " " + id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student(); // creat the object of class without parameters and it will go to constructors without psrsmeters 
            Console.WriteLine(s);
            student k = new student("Torebekov", 111); // create the object with parameters and it will go to the constructor with psrsmeters 
            Console.WriteLine(k);
        }

    }
}
