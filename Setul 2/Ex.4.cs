using System;
using System.Runtime.Remoting.Messaging;

namespace Ex._4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul cautat: ");
            int a = int.Parse(Console.ReadLine());
            int poz = CautaNumar(n, a);
            if (poz != -1)
            {
                Console.WriteLine($"Numarul {a} se afla pe pozitia {poz}.");
                Console.ReadLine();

            }
            else
            {
                Console.Write("Numarul cautat nu se afla in secventa.");
                Console.WriteLine("-1");
            }
        }

         static int CautaNumar(int lungime, int numarCautat)
        {
            for (int i = 0; i < lungime; i++)
            {
                Console.Write($"Introduceti elementul {i} din secventa.");
                int numar = int.Parse(Console.ReadLine());
                if (numar == numarCautat)
                
                    return i;
                
                
                    
            }
return -1;
        } 
      
    }
}

