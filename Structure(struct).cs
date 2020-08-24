using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    class Structure
    {
       public struct Thestruct
        {
            string Name;
            int Age;
            string City;
            string Phone;
            char gender;
            public void Values()
            {
               
                Console.WriteLine("Please enter your Name");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Your Age");
                Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Your City");
                City = Console.ReadLine();

                Console.WriteLine("Enter Your Phone Number");
                Phone = Console.ReadLine();

                Console.WriteLine("Enter Your Gender: M/F/T");
                gender = Convert.ToChar(Console.ReadLine());
                
             }
            
            public void Display()
            {
                Console.WriteLine("Your details: \n Name :{0} \n Age :{1} \n City :{2} \n Phone:{3} \n Gender:{4} \n", Name,Age,City,Phone,gender);
            }
        }

        class Program
        {
            public static void Main(string[] args)
            {
                Thestruct Vineeth = new Thestruct();
                Vineeth.Values();
                Vineeth.Display();
                Console.ReadKey();
        }

        }
    }

}
