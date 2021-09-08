using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Final
{
    class A2
    {
        public void Run()
        {
            Console.Write("how many number :> ");
            int input = Convert.ToInt32(Console.ReadLine());
            double[] data = new double[input];
            for (int i = 0; i < data.Length; i++)
            {
                try
                {
                    Console.Write($"input data[{i + 1}] :> ");
                    data[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("***invalid value***");
                    i--;
                }
            }

            try
            {
                Console.Write("input data to search :> ");
                double searchData = Convert.ToDouble(Console.ReadLine());

                DisplayDataIndex(data);
                DisplayDataSum(data, searchData);
            }
            catch
            {
                Console.WriteLine("***invalid value***");
            }
        }

        private void DisplayDataIndex(double[] data)
        {
            Console.WriteLine("\nindex");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine("");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"{data[i]}\t");
            }
            Console.WriteLine("");
        }

        private void DisplayDataSum(double[] data, double search)
        {
            double sum = 0.0;
            for (int i = 0; i < data.Length; i++)
            {
                if (search.Equals(data[i]))
                {
                    sum += data[i];
                }
            }
            Console.WriteLine("\ndata\tsum");
            Console.WriteLine($"{search}\t{sum}");
        }
    }
}
