using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Final
{
    class A4
    {
        public void Run()
        {
            string input;
            bool isExit = false;
            List<int> data = new List<int> { };
            while (!isExit)
            {
                try
                {
                    Console.Write($"input data[{data.Count + 1}] :> ");
                    input = Console.ReadLine();
                    if (input.Equals("0"))
                    {
                        isExit = true;
                    }
                    else
                    {
                        data.Add(Convert.ToInt32(input));
                    }
                }
                catch
                {
                    Console.WriteLine("***invalid value***");
                }
            }
            Console.WriteLine("\ndata from villager :");
            for (int i = 0; i < data.Count; i++)
            {
                Console.Write($"{data[i]} ");
            }

            Console.WriteLine("\nscore of each applycant :");
            int[] sum = ScoreSum(data);
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write($"{sum[i]} ");
            }
            Console.WriteLine("");
            FindHeadAss(sum);

        }
        private int[] ScoreSum(List<int> data)
        {
            int[] scores = new int[10];
            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    if (i.Equals(data[j]))
                    {
                        scores[i] += 1;
                    }
                }
            }

            return scores;
        }

        private void FindHeadAss(int[] sum)
        {
            int headIndex = 0;
            int assIndex = 0;
            int maxHead = sum[0];
            int maxAss = sum[0];
            for (int i = 0; i < sum.Length; i++)
            {
                if(sum[i] > maxHead)
                {
                    maxHead = sum[i];
                    headIndex = i;
                }
            }
            for (int i = 0; i < sum.Length; i++)
            {
                if (sum[i] > maxAss && sum[i] < maxHead)
                {
                    maxAss = sum[i];
                    assIndex = i;
                }
            }
            Console.Write($"Head is number {headIndex} \tvote_score is {maxHead}");
            Console.Write($"\nAssistant is number {assIndex} \tvote_score is {maxAss}\n");

        }
    }
}
