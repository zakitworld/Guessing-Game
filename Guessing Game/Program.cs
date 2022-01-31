using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int guess;
            bool isGuessed;
            Random rd = new Random();
            int rand_num = rd.Next(0, 100);
            Console.WriteLine("Random Number = "+rand_num);
            isGuessed = false;
            while (!isGuessed)
            {
                Console.WriteLine("Enter an integer greater than or equal to 0 and less than 100 ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == num)
                {
                    Console.WriteLine("You guess the correct answer ");
                    isGuessed = true;
                }
                else if (guess < num)
                    Console.WriteLine("Your guess is lower than the number, guess again ");
                else
                    Console.WriteLine("Your guess is higher than the number, guess again!");
            }
        }
    }
}
