using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class PlusMinus
    {
        public static void plusMinus(List<int> arr)
        {
            double positivos = 0;
            double negativos = 0;
            double zeros = 0;
            for (int i = 0; i < arr.Count(); i++)
            {
                if(arr[i] > 0){
                    positivos++;
                }
                else if(arr[i] < 0){
                    negativos++;
                }
            }
            zeros = (arr.Count() - (positivos + negativos)) / arr.Count();
            Console.WriteLine("{0:0.000000}", positivos / arr.Count());
            Console.WriteLine("{0:0.000000}", negativos / arr.Count());
            Console.WriteLine("{0:0.000000}", zeros);
        }
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
}