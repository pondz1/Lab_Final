using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Final
{
    class A6
    {
        public void Run()
        {
            Console.Write("how many student :> ");
            int input = Convert.ToInt32(Console.ReadLine());
            double[] data = new double[input];
            Dictionary<string, int> projects = new Dictionary<string, int>();
            projects.Add("A", 0);
            projects.Add("B", 0);
            projects.Add("C", 0);
            projects.Add("F", 0);

            Dictionary<string, int> proposals = new Dictionary<string, int>();
            proposals.Add("S", 0);
            proposals.Add("U", 0);

            int countPropos = 0;
            int countProjec = 0;

            for (int i = 0; i < data.Length; i++)
            {
                try
                {
                    Console.Write($"Type of exam\t: ");
                    string type = Console.ReadLine();
                    Console.Write($"Exam score\t: ");
                    double score = Convert.ToDouble(Console.ReadLine());
                    string grade = Grade(type, score);
                    Console.WriteLine($"Exam result\t: {grade}\n");

                    if (projects.ContainsKey(grade.ToUpper()))
                    {
                        countProjec += 1;
                        projects[grade.ToUpper()] += 1;
                    }
                    else if (proposals.ContainsKey(grade.ToUpper()))
                    {
                        countPropos += 1;
                        proposals[grade.ToUpper()] += 1;
                    }

                }
                catch
                {
                    Console.WriteLine("***invalid value***");
                    i--;
                }
            }

            Console.WriteLine($"\nProposal {countPropos} students");
            Console.WriteLine($"S = {proposals["S"]}, U = {proposals["U"]}");

            Console.WriteLine($"Project {countProjec} students");
            Console.WriteLine($"A = {projects["A"]}, B = {projects["B"]}, C = {projects["C"]}, F = {projects["F"]}\n");

        }
        private string Grade(string type, double score)
        {
            if (string.Equals(type, "t", StringComparison.OrdinalIgnoreCase))
            {
                if (score >= 80)
                {
                    return "A";
                }
                else if (score >= 60)
                {
                    return "B";
                }
                else if (score >= 50)
                {
                    return "C";
                }
                else
                {
                    return "F";
                }
            }
            else if (string.Equals(type, "p", StringComparison.OrdinalIgnoreCase))
            {
                if (score >= 60)
                {
                    return "S";
                }
                else
                {
                    return "U";
                }
            }
            else
            {
                return "Type Error!";
            }
        }
    }
}
