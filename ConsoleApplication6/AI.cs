using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class AI : Player
    {
        // member variables

        // constructor
        public AI()
        {

        }
        // member methods
        public override void ChooseName()
        {
            name = "computer HAL";
            Console.WriteLine("You are challenging the computer named HAL.\n");
        }
        public override void ChooseChoice()
        {
            Random randomNumber = new Random();
            int computerChoice = randomNumber.Next(4);
            if (computerChoice == 0)
            {
                choice = "rock";  //Console.Write("The computer chose rock.");
            }
            else if (computerChoice == 1)
            {
                choice = "paper"; //Console.WriteLine("The computer chose paper.");
            }
            else if (computerChoice == 2)
            {
                choice = "scissors"; //Console.WriteLine("The computer chose scissors.");
            }
            else if (computerChoice == 3)
            {
                choice = "lizard"; //Console.WriteLine("The computer chose lizards.");
            }
            else
            {
                choice = "spock"; //Console.WriteLine("The computer chose spock.");
            }
            DisplayChoice();
        }
        public override void DisplayChoice()
        {
            if (choice == "rock")
            {
                Console.WriteLine($"{name} chose { choice }.");
            }
            else if (choice == "paper")
            {
                Console.WriteLine($"{name} chose { choice }.");
            }
            else if (choice == "scissors")
            {
                Console.WriteLine($"{name} chose { choice }.");
            }
            else if (choice == "lizard")
            {
                Console.WriteLine($"{name} chose { choice }.");
            }
            else
            {
                Console.WriteLine($"{name} chose { choice }.");
            }
            //Console.ReadLine();
        }
    }
}
