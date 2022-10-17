using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, k, aux, nr, max = -1, nmax = -1;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            if (a > b)
            {
                k = a;
                a = b;
                b = k;
            }
            for (int i = a; i <= b; ++i)
            {
                aux = i;
                nr = 1;
                while (aux != 1)
                {
                    nr = nr + 1;
                    if (aux % 2 == 0) aux = aux / 2;
                    else aux = 3 * aux + 1;
                }
                if (nr > nmax)
                {
                    max = i;
                    nmax = nr;
                }

            }
            Console.WriteLine(nmax + " " + max);
            Console.ReadKey();
        }
    }
}
