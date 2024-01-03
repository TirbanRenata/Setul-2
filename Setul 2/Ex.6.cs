using System;
using System.Collections.Generic;
using System.Linq;
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
            int [] secventa=new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1} din secventa: ");
                secventa[i] = int.Parse(Console.ReadLine());
            }

                bool SuntCrescatoare = Verifica(secventa);
                    if (SuntCrescatoare)
                
                    Console.WriteLine("Numerele din secventa sunt in ordine crescatoare.");
                
                else
                
                    Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare.");
                

              
            
            
        }
        private static bool Verifica(int[] sequence)
        {
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] < sequence[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
