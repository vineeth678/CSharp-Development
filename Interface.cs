using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vineeth
{
    // Declaring an Interface and defining methods with no body.
    interface IVineeth
    {
        void Display();
        void GetInfo();
    }

    //Inheriting an Interface and defining the bodies of the methods.
    class Program : IVineeth
    {
        public void Display()
        {
            Console.WriteLine("Hello I'm Displaying");
        }
        public  void GetInfo()
        {
            Console.WriteLine("Hello Info is here");
        }

        public static void Main(string[] args)
        {
            //creating an object with reference to the inherited class
            Program v = new Program();

            //Calling the Defined methods using the object reference
            v.GetInfo();
            v.Display();

            Console.ReadKey();
            
        }
    }

    
}
