using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            int[] secventa = new int[n];
            int max = 0;
            int min = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1} din secventa: ");
                secventa[i] = int.Parse(Console.ReadLine());
            }
            int min = secventa[0];
            int max = secventa[0];

            for (int i = 1; i < n; i++)
            {
                if (secventa[i] < min)
                {
                    min = secventa[i];
                }

                if (secventa[i] > max)
                {
                    max = secventa[i];
                }
            }

            Console.WriteLine($"Cea mai mica valoare din secventa este: {min}");
            Console.WriteLine($"Cea mai mare valoare din secventa este: {max}");

            Console.ReadLine();
        }
    }
    
}

