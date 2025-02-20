using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 2;

            List<int> path = new List<int>();
            int current = 1;

            do
            {
                path.Add(current);
                current = (current + m - 1) % n + 1;
            } while (current != 1);
            Console.WriteLine("Путь: " + string.Join(" -> ", path));
        }
    }
}
