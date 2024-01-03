using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            int[] secventa = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1} din secventa: ");
                secventa[i] = int.Parse(Console.ReadLine());

            }
           
            int maxConsecutiveCount = 0;
            int currentConsecutiveCount = 1;

            for (int i = 1; i < secventa.Length; i++)
            {
                if (secventa[i] == secventa[i - 1])
                {
                    currentConsecutiveCount++;
                }
                else
                {
                    if (currentConsecutiveCount > maxConsecutiveCount)
                    {
                        maxConsecutiveCount = currentConsecutiveCount;
                    }
                    currentConsecutiveCount = 1;
                }
            }

            if (currentConsecutiveCount > maxConsecutiveCount)
            {
                maxConsecutiveCount = currentConsecutiveCount;
            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este:{maxConsecutiveCount} ");

        }
    }
}
