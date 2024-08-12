using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class aVeryBigSum
    {
        // Laço Foreach para iterar cada elemento do array e somar todos os valores.
        public static long aVeryBigSum(List<long> ar)
        {
            //List<long> = new List<long>{} 
            long VeryBigSum = 0;
            foreach(long element in ar){
                VeryBigSum += element;
            }
            return VeryBigSum;
        }
    }
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = Result.aVeryBigSum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}