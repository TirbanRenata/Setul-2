using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti cele {n} numere: ");
            int x = int.Parse(Console.ReadLine());
            int bit = 1, ok = 1;
            int y = int.Parse(Console.ReadLine());
            if (y < x)
                ok = 0;

            for (int i = 2; i < n; i++)
            {
                int z = int.Parse(Console.ReadLine());
                if (z < y && bit == 1)
                    bit = 0;
                if (z > y && bit == 0)
                    ok = 0;
                y = z;
            }
            if (ok == 1 && bit == 0)
                Console.WriteLine("Secventa de numere este bitonica");
            else
                Console.WriteLine("Secventa de numere nu este bitonica");
        }
    }
}
