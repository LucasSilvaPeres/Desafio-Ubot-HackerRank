using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class CompareTheTriples
    {
        //Laço For simples para comparar os elementos das listas usando o comprimento de uma lista como delimitador.
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> Pontuacao = new List<int>{ 0, 0 };
            for(int i=0; i < a.Count; i++)
            {
                if(a[i] > b[i])
                    Pontuacao[0]++;
                else if(a[i] < b[i])
                    Pontuacao[1]++;
            }
            return Pontuacao;
        }
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Result.compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}