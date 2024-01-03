using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ex._6
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
            bool EsteCrescatoare = EsteMonotona(secventa);
            if (EsteCrescatoare)

                Console.WriteLine("Secventa este monotona.");

            else

                Console.WriteLine("Secventa nu este monotona.");
            bool EsteDescrescatoare= EsteMonotona(secventa);
            if (EsteDescrescatoare)
                Console.WriteLine("Secventa este monotona");

            else
                Console.WriteLine("Secventa nu este monotona.");


            bool EsteMonotona(int[] secventa)
            {
                bool EsteCrescatoare = true;
                bool EsteDescrescatoare = true;

                for (int i = 1; i < secventa.Length; i++)
                {
                    if (secventa[i] < secventa[i - 1])
                    {
                        EsteCrescatoare = false;
                    }
                    if (secventa[i] > secventa[i - 1])
                        EsteDescrescatoare = false;


                }
                return EsteCrescatoare || EsteDescrescatoare;
               

            }
        }
        
    }
}
