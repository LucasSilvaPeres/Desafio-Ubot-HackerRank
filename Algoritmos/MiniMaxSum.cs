using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class MiniMaxSum
    {
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            long sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            int count = arr.Count() - 1;
            long min = sum - arr[count];
            long max = sum - arr[0];
            Console.WriteLine(min + " " + max);
        }
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }
}