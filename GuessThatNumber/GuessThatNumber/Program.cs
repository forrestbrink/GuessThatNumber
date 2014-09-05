using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        //create a random number between 1 and 100
       public static Random rng = new Random();
       public static int ranNum = rng.Next(0, 101);
        //create a "guess count"
      public static  int guesses = 0;
        static void Main(string[] args)
        {
            //ask the user to guess a number
            Console.WriteLine("Guess a Number.");
            string input = Console.ReadLine();
            //convert the string to an integer
            GuessThatNumber(int.Parse(input));

            Console.ReadKey();
        }
        //create a function, GuessThatNumber that takes an integer parameter number
        static void GuessThatNumber(int number)
        {
            
            //create a boolean to say whether or not the user has guessed correctly
            bool input = false;
            while (input == false)
            {
                //if the number is correct
                if (number == ranNum)
                {
                    //congratulate the user
                    //and add 1 guess
                    guesses++;
                    Console.WriteLine("Congratulation, you guessed the right number!");
                    Console.WriteLine("It took you " + guesses + " tries to get it right!");
                    input = true;
                }
                //if number is too low
                else if (number < ranNum)
                {
                    //ask to try again
                    guesses++;
                    Console.WriteLine("We're sorry, you guessed too low.  Try again!");
                    GuessThatNumber(int.Parse(Console.ReadLine()));

                }
               //if number is too high
                else if (number > ranNum)
                {
                    //try again
                    guesses++;
                        Console.WriteLine("We're sorry, you guessed too high.  Try again!");
                        GuessThatNumber(int.Parse(Console.ReadLine()));
                }
            }
           
        }
    }
}
