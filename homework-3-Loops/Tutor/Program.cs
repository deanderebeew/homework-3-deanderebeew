using System;

namespace Tutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int lefthandoperator = rand.Next(1, 52);
            int righthandoperator = rand.Next(1, 52);
            int sum = righthandoperator + lefthandoperator;

            int answer;
            do
            {


            Console.WriteLine($"\t{lefthandoperator.ToString("N0")} + {righthandoperator.ToString("N0")} = ?\t What is your answer? ");
            string input = Console.ReadLine();
            

               if (int.TryParse(input, out answer) == false) 
               {
                Console.WriteLine("Invalid Input, Goodbye");
                Environment.Exit(-1);
               }

                if (sum != answer)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, please try again");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine();
            } while (sum != answer);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Congratulations, you got it right");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
