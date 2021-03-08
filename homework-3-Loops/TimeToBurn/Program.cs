using System;

namespace TimeToBurn
{
    class Program
    {
        const double Calories_Burned = 3.9;
        static void Main(string[] args)
        {
            Console.WriteLine("What is your calorie goal that you would you like to burn?");
            string answer = Console.ReadLine();

            double goal;
            if (double.TryParse(answer, out goal) == false)
            {
                Console.WriteLine($"{answer} was an invalid goal. Goodbye!");
                Environment.Exit(-1);

            }
            double calories_burned_sofar = 0;
            int minutes = 0;

            if (goal == 0)
            {
                Console.WriteLine("Come on, you can do better than that!");
            }

            else
            {

                while (calories_burned_sofar < goal)
                {
                    minutes++;
                    calories_burned_sofar = calories_burned_sofar + Calories_Burned;
                    Console.WriteLine($"After {minutes.ToString("N0")} minutes, you've burned {calories_burned_sofar.ToString("N2")}");

                }
           
            }
        }

    }
}
