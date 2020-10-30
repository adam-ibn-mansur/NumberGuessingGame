# NumberGuessingGame
A fun little game involving guessing between 0 and 100. Comes with a counter that tallies how many attempts it took the player to guess the correct number.

# How it works
The program creates a variable and initializes it to a natural number value between 0 and 100. A boolean that determines whether or not we won yet is created. The attempt counter is initialized to 1, should the player guess the right number on the first try.

The algorithm that does all of the work for us is a switch statement nested within a do-while loop.

When the program is ran, it awaits the player input, parses it to an int, compares that int to winNum via a switch statement, with the input as the conditional. Each failed attempt at guessing the correct value displays a message that hint at how to guess next, and increments the counter by 1, and we repeat the do-while loop. When the player successfully guesses the correct value, we display the victory message, display the counter and exit the do-while loop, thus terminating the program.
