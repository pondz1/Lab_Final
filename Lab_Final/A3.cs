using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Final
{
    class A3
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
            double[] maxMin = MaxMin(data);
            Console.WriteLine($"\nMax is {maxMin[0]}");
            Console.WriteLine($"Min is {maxMin[1]}");
            Console.WriteLine($"Diff is {Math.Abs(maxMin[0] - maxMin[1])}");
        }
        private double[] MaxMin(double[] data)
        {
            double[] maxMin = { data[0], data[0] };
            foreach (double value in data)
            {
                if (value > maxMin[0])
                {
                    maxMin[0] = value;
                }
                if (value < maxMin[1])
                {
                    maxMin[1] = value;
                }
            }
            return maxMin;
        }
    }
}
