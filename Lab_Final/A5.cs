using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Final
{
    class A5
    {
        public void Run()
        {
            Console.Write("how many number :> ");
            int input = Convert.ToInt32(Console.ReadLine());
            double[] data1 = new double[input];
            for (int i = 0; i < data1.Length; i++)
            {
                try
                {
                    Console.Write($"input data1[{i + 1}] :> ");
                    data1[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("***invalid value***");
                    i--;
                }
            }
            Console.WriteLine("\n------------------------");
            double[] data2 = new double[input];
            for (int i = 0; i < data2.Length; i++)
            {
                try
                {
                    Console.Write($"input data2[{i + 1}] :> ");
                    data2[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("***invalid value***");
                    i--;
                }
            }

            SumData(data1, data2);
        }

        private void SumData(double[] data1, double[] data2)
        {
            Console.WriteLine("");
            double[] sums = new double[data1.Length];
            for (int i = 0; i < data1.Length; i++)
            {

                sums[i] = Math.Pow(data1[i] - data2[i], 2);
                Console.WriteLine($"data1[{data1[i]}] - data2[{data2[i]}] = {sums[i]}");

            }
            Console.WriteLine("\n------------------------");
            double sum = 0.0;
            for (int i = 0; i < sums.Length; i++)
            {
                sum += sums[i];

            }
            Console.WriteLine($"Sum of Diff-Square is [{sum}]\n");

            //data1.Sum();
        }
    }

}
