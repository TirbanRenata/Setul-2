using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Introduceti lungimea secventei: ");
            int n=int.Parse(Console.ReadLine());
            int nrEgaleCuPozitia = 0;
            for(int i = 0;i<n;i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int numar=int.Parse(Console.ReadLine());
                if (numar == i)
                {
                    nrEgaleCuPozitia++;
                }
            }
            Console.WriteLine($"Numerele egale cu pozitia in secventa: {nrEgaleCuPozitia}");
        }
        
    }
}
