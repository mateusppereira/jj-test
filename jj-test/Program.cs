using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jj_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(doTest("9 5", "1 1 0 0 3 7 1 1 1"));
            Console.ReadLine();
        }

        static int doTest(string strArr, string strNumbers)
        {
            int N = Convert.ToInt32(strArr.Split(' ')[0]);
            int S = Convert.ToInt32(strArr.Split(' ')[1]);

            string[] strArrayNumbers = new string[] { "" };
            strArrayNumbers = strNumbers.Split(' ');

            int[] ints = Array.ConvertAll(strArrayNumbers, int.Parse);

            int qtd = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (ints[i] > S)
                    continue;
                else
                {
                    int counter = 0;
                    int sum = ints[i];

                    while (sum <= S && counter + i < N - 1)
                    {
                        counter++;
                        if (sum == S) {
                            qtd = counter;
                            break;
                        }
                        sum += ints[i + counter];
                    }
                }
            }

            return qtd;
        }
    }
}
