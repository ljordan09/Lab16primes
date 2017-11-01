using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                //array of primes
                int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229 };

                PrimeIndex(primes);//calls method that requests user input and accesses the array of primes
                
                DoAgain();//call method that repeats the program
            } while (repeat);
        }

        private static void PrimeIndex(int[] primes)
        {
                       
                Console.WriteLine("This application displays the first 50 prime numbers. from first prime number on. " +
                        "\nChoose a position 1-50 to see its prime number:  ");
                string input = Console.ReadLine();

                int validInt = Validate(input);//calls method that validates input
                int.TryParse(input, out int number);


                if (number > (primes.Length))
                {
                    Console.WriteLine("Invalid, you must enter a number between 1 - 45");
                    PrimeIndex(primes);
                }
                else
                {
                    Console.WriteLine($"\nThe number {number} prime is {primes[number - 1]}.");
                }
            
        }

        public static int Validate(string input)//when the program runs this code block I get an IndexOutOfRange Exception. 
        {
            //validates the users input
            int number = 0;
            while (!int.TryParse(input, out number) || number <= 1 || number > 229 || number < 1)
            {
                Console.WriteLine("Error, you must enter a number between 1 - 45. Try again:");
                 input = Console.ReadLine();
            }

            return number;
        }
        
        public static string DoAgain()//runs program again
        {
            while (true)
            {
                Console.Write("\nDo you want to run the program again? Yes or No: ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return ("Great! ");
                }
                else if (test == "n" || test == "no")
                {
                    Console.WriteLine("Thanks!");

                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Enter yes or no.");
                }
            }
        }


    }
}
