using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_rekurzív
{
    class Program
    {
        static int fibonacci(int n)
        {
            if ( n==0)
            {
                return 0;
            }
            else if (n==1)
            {
                return 1;

            }
            else
            {
                return fibonacci(n - 2) + fibonacci(n - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci(5));

            Console.ReadKey();
        }
    }
}
