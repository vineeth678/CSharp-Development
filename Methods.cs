// Methods Topic-1 Initiation and Declaration

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
  class MethodDeclaration
    {
        //Declaring Global Variables
        public int A;
        public int B;

        //Declaring and initialising Method
        static int Add(int A, int B)
        {
            return A + B;
        }

        public static void Main()
        {
            // Calling a Method
            // As the method is static, no object reference is needed

            int X = Add(5, 6);
            Console.WriteLine(X);
            Console.ReadKey();
            
        }     
    }
}

//Topic -2 Method Overloading
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class MethodOverloading
    {
        /* Method Overloading is when method has same name and different parameters
         * This usually occurs when the work is same but changes with parameters
         */

        // Method is same mechanism but integers as parameters
        public static int Add(int a, int b)
        {
            return a + b;
        }
        // Method is same mechanism but Doubles as parameters
        public static double Add(double a, double b)
        {
            return a + b;
        }

       public static void Main()
        {
            int z = Add(12234, 545878);
            double X = Add(233.44, 434242.45);
            Console.WriteLine("Integer addition is {0}", z);
            Console.WriteLine("Double addition is {0}",X);

            Console.ReadKey();
        }
    }
}

//Topic -3 Method Overriding.

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class MethodOverloading
    {
        // Defining a Method with Virtual Keyword so the the derived class can modify the method.
        public virtual int Add(int a, int b)
        {
            int Z = a + b;
            Console.WriteLine("{0}\n\n", Z);
            return Z;
        }
    }

    // Deriving a class from the previous class.
    public class MethodOverriding : MethodOverloading
    {
        //Overriding a method with the needed properties.
        public override int Add(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Please enter valid Numbers greater than Zero");
                return 0;
            }
            else
            {
                int Z = a + b;
                Console.WriteLine("Numbers are Valid and the result is {0}", Z);
                return Z;
            }
        }
    }

    class Program
    {
      public static void Main()
        {
            // Creating an object reference of Base class
            MethodOverloading Vinnu = new MethodOverloading();

            //Calling the base class method as the instance is of base class.
            Vinnu.Add(0, 1233);
            Vinnu.Add(12, 456);

            //Creating an Object reference of the derived class.
            MethodOverriding Vineeth = new MethodOverriding();

            //Calling the method, As this is derived class, The modified method is called.
            Vineeth.Add(123, 0);
            Vineeth.Add(123, 46646);

            Console.ReadKey();
                
        }

    }
}

    

    

    
