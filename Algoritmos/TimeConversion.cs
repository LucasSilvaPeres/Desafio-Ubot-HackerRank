using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            string amOuPm = s.Substring(8,2);
            int horas = int.Parse(s.Substring(0,2));
            if(amOuPm == "PM")
            {
                if(horas != 12)
                {
                    horas += 12;
                }
            }
            else if(amOuPm == "AM")
            {
                if(horas == 12)
                {
                    horas = 0;
                }
            }
            string horasConvertidas = horas.ToString().PadLeft(2,'0') + s.Substring(2,6);
            return horasConvertidas;
        }

        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}