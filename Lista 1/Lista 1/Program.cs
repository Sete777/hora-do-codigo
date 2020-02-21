using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] p1 = Console.ReadLine().Split(' ');
            string[] p2 = Console.ReadLine().Split(' ');
            int x1 = int.Parse(p1[0]);
            int y1 = int.Parse(p1[1]);
            double z1 = double.Parse(p1[2]);
            int x2 = int.Parse(p2[0]);
            int y2 = int.Parse(p2[1]);
            double z2 = double.Parse(p2[2]);
            double k = y1 * z1 + y2 * z2;
            Console.WriteLine($"VALOR A PAGAR: R$ {k:0.00}");
            Console.WriteLine($"{k}");
        }
    }
}
