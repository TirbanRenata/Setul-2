using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            int[] secventa = new int[n];
            int suma = 0;
            int produs = 1;
            for(int i = 0; i <= n; i++)
            {
                suma = n*(n+1)/2; ;
            }
            for (int i = 1; i <= n; i++)
            {
                produs *= i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este: {suma}");
            Console.WriteLine($"Produsul numerelor de la 1 la {n} este: {produs}");
        }
    }
}
