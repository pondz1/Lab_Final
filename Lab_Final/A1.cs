using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Final
{
    class A1
    {
        public void Run()
        {
            string input;
            bool isExit = false;
            while (!isExit)
            {
                MenuString();
                Console.Write("menu :> ");
                input = Console.ReadLine();



                if (input.Equals("1"))
                {
                    Line();
                }
                else if (input.Equals("2"))
                {
                    Rectangle();
                }
                else if (input.Equals("3"))
                {
                    Triangle();
                }
                else
                {
                    Console.WriteLine("Exit program....");
                    isExit = true;
                }

            }
        }

        void MenuString()
        {
            Console.WriteLine("\tMenu");
            Console.WriteLine("1 - Line");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("3 - Triangle");
            Console.WriteLine("4 - Exit");
            Console.WriteLine("------------");
        }
        void Line()
        {
            try
            {
                Console.Write("input length of line :> ");
                int input = Convert.ToInt32(Console.ReadLine());
                while (input != 0)
                {
                    input--;
                    Console.Write($"{input}");
                }
                Console.WriteLine("\n------------");
            }
            catch
            {
                Console.WriteLine("invalid value");
            }
        }

        void Rectangle()
        {
            try
            {
                Console.Write("input length of line :> ");
                int lengthInput = Convert.ToInt32(Console.ReadLine());
                Console.Write("input number of line :> ");
                int numberInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                for (int i = 0; i < numberInput; i++)
                {

                    for (int j = 0; j < lengthInput; j++)
                    {
                        Console.Write(i + 1);
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
            catch
            {
                Console.WriteLine("invalid value");
            }
        }

        void Triangle()
        {
            try
            {
                Console.Write("input width of line :> ");
                int input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                for (int i = input; i >= 1; i--)
                {

                    for (int j = 1; j <= i; j++)
                    {
                        if(i == j)
                        {
                            Console.Write(i);
                        } else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
            catch
            {
                Console.WriteLine("invalid value");
            }
        }
    }
}
