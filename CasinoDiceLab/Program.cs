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
                Console.WriteLine("Choose the number of sides for your dice");
                int sides = int.Parse(Console.ReadLine());
                
                diceRoller(sides);
                

                runProgram = getContinue();
            }
        }

        //method to implement output for different 6 sided dice combinations

        static void sixSides(int dice1, int dice2)
        {
            if (dice1 == 1 && dice2 == 1)
            {
                Console.WriteLine("You got sssssnake eyes!");
            }
        }
        
        //method to generate random numbers
        static int diceRoller(int sides)
        {
            int result = 0;
            Random rand = new Random();
            int dice1 = rand.Next(1, sides);
            int dice2 = rand.Next(1, sides);
            int total = dice1 + dice2;

            Console.WriteLine($"You rolled a {dice1} and a {dice2}. Your total is {total}");

            //if(sides == 6 && dice1 == 1 && dice2 == 1)
            //{
            //    Console.WriteLine("You rolled a ssssnake eyes");
            //}
            //else if (sides == 6 && (dice1 == 1 && dice2 == 2) || (dice2 == 1 && dice1 == 2))
            //{
            //    Console.WriteLine("You rolled an ace deuce");
            //}
            //else if (sides == 6 && dice1 == 6 && dice2 == 6)
            //{
            //    Console.WriteLine("You rolled a box cars.");
            //}
            

            return result;
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
