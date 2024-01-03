using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._11
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
            double inverseSum = 0;

            foreach (double number in secventa)
            {
                inverseSum += 1 / number;
            }
            Console.WriteLine($"Suma inverselor acestor numere este: {inverseSum}");
        }
    }
}
