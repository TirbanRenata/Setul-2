using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti cele {n} numere: ");
            int x = int.Parse(Console.ReadLine());
            int schimb = 0, status = 0;

            for (int i = 1; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (y > x)
                {
                    if (status == -1)
                    {
                        schimb++;
                        status = 1;
                    }
                    if (status == 0)
                        status = 1;
                }
                if (y < x)
                {
                    if (status == 1)
                    {
                        schimb++;
                        status = -1;
                    }
                    if (status == 0)
                        status = -1;
                }


            }
            if (schimb <= 2)
                Console.WriteLine("Secventa de numere este bitonica rotita");
            else
                Console.WriteLine("Secventa de numere nu este bitonica rotita");


        }
    }
}
