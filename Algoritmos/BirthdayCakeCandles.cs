using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class BirthdayCakeCandles
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            candles.Sort();
            candles.Reverse();
            int nCandles = 1;
            for (int i = 1; i < candles.Count(); i++){
                if(candles[i] == candles[0]){
                    nCandles++;
                }
            }
            return nCandles;
        }
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = Result.birthdayCakeCandles(candles);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}