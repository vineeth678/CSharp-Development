using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
   // Methods Topic-1 Initiation and Declaration
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
    
