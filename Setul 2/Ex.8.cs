using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introduceti valoarea lui n: ");
            int n = int.Parse(Console.ReadLine());

            int rez = Fibonacci(n);
            Console.WriteLine($"Al {n}-lea termen din sirul lui Fibonacci este: {rez}");
        }

        static int Fibonacci(int n)
        {
            if (n <= 0)
                throw new ArgumentException("n trebuie sa fie un numar intreg.");

            if (n == 1)
                return 0;

            if (n == 2)
                return 1;

            int f1 = 0;
            int f2 = 1;
            int current = 0;

            for (int i = 3; i <= n; i++)
            {
                current = f1 + f2;
                f1 = f2;
                f2 = current;
            }

            return current;
        }  
    }
}
