using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente din secventa: ");
            int n=int.Parse(Console.ReadLine());
            int[ ] secventa= new int[n];
            int numerenegative = 0;
            int numerezero = 0;
            int numerepozitive = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                secventa[i]=int.Parse(Console.ReadLine());
                if (secventa[i] < 0)
                {
                    numerenegative++;
                }
                if (secventa[i] == 0)
                {
                    numerezero++;
                }
                if (secventa[i] > 0)
                {
                    numerepozitive++;
                }
            }
            Console.WriteLine($"Dintre cele {n} numere, {numerenegative} sunt negative, {numerezero} sunt zero si {numerepozitive} sunt pozitive.");
        }
    }
}
