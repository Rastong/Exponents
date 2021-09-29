using System;

namespace Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = true;
            Console.WriteLine("Hello, Welcome to the Exponent Calculator.");
            while (end)
            {
                
                Console.WriteLine("Please enter your number.");
                int input = int.Parse(Console.ReadLine());

                if (input >= 1 && input <= 100)
                {
                    Console.WriteLine($"Number      Squared      Cubed");
                    Console.WriteLine($"------------------------------");

                    for (int i = 1; i <= input; i++)
                    {
                        int squ = Squarer(i);
                        int cub = Cuber(i);

                        Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", $"{i}", $"{squ}", $"{cub}"));

                    }
                }
                else
                {
                    Console.WriteLine("Please enter a vaild number");
                }

                Console.WriteLine("would you like to try another number? y/n");
                string whatIf = Console.ReadLine();

                if(whatIf == "n")
                {
                    end = false;
                }
            }
        }
        public static int Squarer(int squ)
        {     
            int square = squ * squ;
            return square;
        }
        public static int Cuber(int cub)
        {
            int cubed = cub * cub * cub;
            return cubed;
        }
    }
}
