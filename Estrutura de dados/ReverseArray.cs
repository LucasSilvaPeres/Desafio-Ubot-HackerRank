using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estrutura de dados
{
    public class ReverseArray
    {
        public static List<int> reverseArray(List<int> a)
        {
            List<int> reversedA = new List<int> {};
            for(int i = 0; i < a.Count(); i++){
                reversedA.Add(a[a.Count() - 1 - i]);
            }
            return reversedA;
        }
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> res = Result.reverseArray(arr);

            textWriter.WriteLine(String.Join(" ", res));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}