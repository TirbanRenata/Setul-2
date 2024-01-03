using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar natural n:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                Console.WriteLine($"Nu exista secventa de {n} numere!");
            else
            {
                Console.WriteLine($"Introduceti o secventa de {n} numere intregi separate prin cate un spatiu: ");
                string sep = Console.ReadLine();
                int y = 0;
                int maxi = -1000000000;
                int mini = 1000000000;
                bool ok1 = true;
                bool ok2 = true;
                for (int i = 0; i < n; i++)
                {
                    int x = Convert.ToInt32(sep.Split()[i]);
                    if (y > x && ok1 == true)
                    {
                        ok1 = false;
                        maxi = y;
                        mini = x;
                    }
                    else if (ok1 == false && (x > maxi || x < mini))
                        ok2 = false;
                    y = x;
                }
                if (ok2)
                    Console.WriteLine("Secventa data este secventa crescatoare rotita");
                else
                    Console.WriteLine("Secventa data nu este secventa crescatoare rotita");
            }
        }
    }
}
