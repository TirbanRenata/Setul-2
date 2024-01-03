using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul de elemente din secventa: ");
            int n=int.Parse(Console.ReadLine());
            int[ ] secventa=new int[n];
            int numerepare = 0;
            for(int i=0; i<n; i++)
            {
                Console.Write($"Introduceti numarul{i + 1}: ");
                secventa[i] = int.Parse(Console.ReadLine());
                if (secventa[i] %2 == 0 )
                    numerepare++;
            }
            Console.WriteLine($"Dintre cele {n} numere, {numerepare} sunt pare.");
        }
    }
}
