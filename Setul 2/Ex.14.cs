using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti cele {n} numere: ");
            int first = 0, schimb = 0, schimb2 = 0;
            int x = int.Parse(Console.ReadLine());
            first = x;
            for (int i = 1; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (y < x)
                {
                    schimb++;
                }
                if (y > x)
                {
                    schimb2++;
                }
                x = y;
            }
            if ((schimb <= 1 && first >= x || schimb == 0) || (schimb2 <= 1 && first <= x || schimb2 == 0))
                Console.WriteLine("Secventa de numere este o secventa monotona rotita");
            else
                Console.WriteLine("Secventa de numere nu este o secventa monotona rotita");
        }
    }
}
