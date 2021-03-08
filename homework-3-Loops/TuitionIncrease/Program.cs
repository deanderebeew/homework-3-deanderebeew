using System;

namespace TuitionIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            double tuition = 12000;
            const double Tuition_Increase = 0.05;

            for (int i = 1; i <= 7; i++)
            {
                //tuition = tuition * (1 + Tuition_Increase);
                tuition *= (1 + Tuition_Increase);
                Console.WriteLine($"The tuition after year {i} will be {tuition.ToString("C0")}.");
            }
         


        }
    }
}
