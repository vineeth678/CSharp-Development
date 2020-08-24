using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // Generics can be used to create classes, structures, interfaces and methods that have placeholders for the type they use.
    // Generics allow you to create type safe data strcutures for both "reference" & "Value" types.
    // Generics perform better than system types because they reduce the need of boxing, unboxing and typecasting the variables or objects.
    // Generics use '<>' to specify data types.
    /* Advantages of using generics
     * Reusability
     * Type safety
     * Performance
     */

    public class Generics<YOU>
    {
        private YOU name;
        public YOU value
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }

        }
    }

    class Program
    {
      public static void Main()
        {
            Generics<string> Vineeth = new Generics<string>();
            Vineeth.value = "Iam Vineeth Kakarla";
            Generics<int> Sridhar = new Generics<int>();
            Sridhar.value = 25;
            Generics<bool> Jaanu = new Generics<bool>();
            Jaanu.value = true;
            Generics<float> Jugaad = new Generics<float>();
            Jugaad.value = 0.0f;


            Console.WriteLine(Vineeth.value);
            Console.WriteLine(Sridhar.value);
            Console.WriteLine(Jaanu.value);
            Console.WriteLine(Jugaad.value);
            Console.ReadKey();
         }
        }
       }

    
