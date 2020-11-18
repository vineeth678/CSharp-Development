using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    // Defining a Class with Certain Fields
    class Class1
    {
        public int? Age;
        public string Name = null;
        public string Company;
        public string Contact;
        public string City;
        //Checking the changes using the demo branch

        // Defining a Constructor with all the fields as Parameters
        public Class1(int Age, string Name, string Company, string Contact, string City)
        {
            this.Age = Age;
            this.Name = Name;
            this.Company = Company;
            this.Contact = Contact;
            this.City = City;
        }
        public Class1(int Age, string Name, string Company, string Contact, string City)
        {
            this.Age = Age;
            this.Name = Name;
            this.Company = Company;
            this.Contact = Contact;
            this.City = City;
        }
        Console.writeLine("Hello world");
        //Defining a constructor with only one Field as a Parameter.
        public Class1(int Age)
        {
            this.Age = Age; 
        }

        //Defining a Method to perform a Certain task
        public void GetDetails() // Instance Method (Without static Keyword)
        {
            Console.WriteLine(" Age is {0}, Name is {1}, Company is {2}, Contact is {3} and City is {4}", this.Age, this.Name, this.Company, this.Contact, this.City);
        }
        
        public static void Main(string[] args) //Main is a static method with static Keyword.
        {
            //Deriving a new class from Class1 with a defined Constructor - All Parameters
          Class1 Raju = new Class1( 23, "Raju", "IBM", "8844566554", "Vizag" );
            Raju.GetDetails();

            //Deriving a new class from Class1 with a defined Constructor - Single Parameter
            Class1 Vineeth = new Class1(23);
            Vineeth.GetDetails();
            Console.ReadKey();

        }
    }
}
