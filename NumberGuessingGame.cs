using System;

namespace NumberGuessingGame
{
    class NumberGuessingGame
    {
        static void Main(string[] args)
        {
            Random r = new Random();     //Generates the random number
            int winNum = r.Next(0, 100); //Sets the threshold between 0 and 100.
            bool win = false;            //Boolean that only becomes true when you guess the right number
            int count = 1;               //Counter. It's set to 1, should the player get it right on the 1st try.

            /* Do-while loop that we only break out of once we guess the right number. When the program is ran, 
             * it awaits the player input, parses it to an int, compares that int to winNum via a switch statement, 
             * with the input as the conditional. Each failed attempt at guessing the correct value displays a message 
             * that hint at how to guess next, and increments the counter by 1, and we repeat the do-while loop. When 
             * the player successfully guesses the correct value, we display the victory message, display the counter 
             * and exit the do-while loop, thus terminating the program.
             */
            do
            {
                Console.Write("Guess a number in between 0 and 100: "); 
                string s = Console.ReadLine(); 

                int i = int.Parse(s); 
                
                switch(i)
                {
                    case int n when (n < winNum && n >= 0):             //Input is too low                
                        Console.WriteLine($"{n} is too low! Guess higher...");      
                        count++;                                                    
                        break;
                    case int n when (n > winNum && n <= 100):           //Input is too high
                        Console.WriteLine($"{n} is too high! Guess lower...");      
                        count++;                                                    
                        break;                                                      
                    case int n when (n == winNum):                      //Input is correct!
                        Console.WriteLine($"{n} is the correct value! " +
                            $"\nYou were able to guess the correct number in {count} attempts. " +
                            $"\nThank you for playing!");                           
                        win = true;                                                 
                        break;                                                      
                    default:                                            //Input is either less than 0 or more than 100
                        Console.WriteLine("Invalid value!");
                        count++; 
                        break; 
                }
            } while (win == false);
        }
    }
}
