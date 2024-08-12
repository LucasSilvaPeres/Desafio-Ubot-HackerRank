using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class Staircase
    {
        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string(' ', n - i - 1) + new string('#', i + 1));
            }
        }
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.staircase(n);
        }
    }
}