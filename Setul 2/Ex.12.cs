using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n=int.Parse(Console.ReadLine());
            int[] secventa = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1} din secventa: ");
                secventa[i] = int.Parse(Console.ReadLine());
            }

            int groupCount = 0;
            bool inGroup = false;

            foreach (int number in secventa)
            {
                if (number != 0)
                {
                    if (!inGroup)
                    {
                        groupCount++;
                        inGroup = true;
                    }
                }
                else
                {
                    inGroup = false;
                }
            }

            Console.WriteLine("Numărul de grupuri de numere consecutive diferite de zero în secvență este: " + groupCount);
        }
    }
}
