using System;

namespace CasinoDiceLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Weanie Hut Jr's Casino.");


            bool runProgram = true;
            while (runProgram)
            {
                int sides = 0;

                //surround user input with trycatch
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Choose the number of sides for your dice");
                        sides = int.Parse(Console.ReadLine());
                        if (sides <= 0)
                        {
                            throw new Exception("Your entry is too low fool.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("That wasn't a valid input.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                //diceRoller(sides);
                int num1 = rollDice(sides);
                int num2 = rollDice(sides);
                Console.WriteLine($"You rolled a {num1} and a {num2}. Your total is {num1 + num2}");
                if (sides == 6)
                {
                    displayCombinations(num1, num2);
                }
                runProgram = getContinue();
            }
        }

        //method to implement output for different 6 sided dice combinations

        static void displayCombinations(int num1, int num2)
        {
            if (num1 == 1 && num2 == 1)
            {
                Console.WriteLine("You got sssssnake eyes!");
            }
            if (num1 == 1 && num2 == 2)
            {
                Console.WriteLine("You got an Ace Deuce");
            }
            if (num2  == 1 && num1 == 2)
            {
                Console.WriteLine("You got an Ace Deuce");
            }
            if (num1 == 6 && num2 == 6)
            {
                Console.WriteLine("You got box cars.");
            }
            if(num2 == 6 && num1 == 6)
            {
                Console.WriteLine("You got box cars.");
            }
            int total = num1 + num2;
            if (total == 7 || total == 11)
            {
                Console.WriteLine("You won.");
            }
            if (total == 2 || total == 3 || total == 12)
            {
                Console.WriteLine("Craps. You lost");
            }

        }
        static int rollDice(int sides)
    {
        Random r = new Random();
        return r.Next(1, sides + 1);
    }

        //method to continue yes or no
        static bool getContinue()
        {
            bool result = true;
            while (true)
            {
                Console.WriteLine("Would you like to roll some more dice? y/n");
                string choice = Console.ReadLine().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    Console.WriteLine("Thank you come again.");
                    break;
                }
                else
                {
                    Console.WriteLine("That wasn't a valid choice.");
                }
            }
            return result;
        }
    }
    
}
