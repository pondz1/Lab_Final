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
            while(!isExit)
            {
                Console.Write("menu :> ");
                input = Console.ReadLine();

                if(input == "4")
                {
                    isExit = true;
                }
                
            }
        }

        void MenuString()
        {
            Console.WriteLine("1 - Line");
            Console.WriteLine("2 - Rectangle");
            Console.WriteLine("3 - Triangle");
            Console.WriteLine("4 - Exit");
            Console.WriteLine("------------");
        }
    }
}
