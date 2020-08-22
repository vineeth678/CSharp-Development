using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineethDemo
{

    //Defining an Abstract Class with fields and methods(with no bodies)
    abstract class Jaanu
    {
        public int Name;
        public int Age;
        public abstract void Display();
        public abstract void YourName();
    }

    // Inheriting a class named Vineeth from abstract class Jaanu 
    // Overriding Methods and defining them. 
    class Vineeth : Jaanu
    {
        public override void Display()
        {
            Console.WriteLine(Name);
        }
        public override void YourName()
        {
            Console.WriteLine(Age);
        }
    }
    class Program
    { 
        public static void Main(string [] args)
        {
            Vineeth Raju = new Vineeth();
            Raju.Age = 52;
            Raju.Name = 5454;
            Raju.YourName();
            Raju.Display();

            Console.ReadKey();
           
           
        }
    }
}
