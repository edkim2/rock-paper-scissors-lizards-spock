using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Player
    {
        // member variables
        public string choice;
        public int score;
        public string name;
       

        // constructor
        public Player()
        {
            score = 0;
            ChooseName();
        }
        // member methods
        public virtual void ChooseName()
        {
            Console.WriteLine("Please enter in your name.");
            name = Console.ReadLine();
            Console.Clear();
        }
        public virtual void ChooseChoice()
        {
            Console.WriteLine(name + ", please choose either rock, paper, scissors, lizard, or spock?");
            choice = Console.ReadLine();
            Console.WriteLine("You chose " + choice + ".");
            Console.Clear();
        }
        public virtual void DisplayChoice()
        {
            Console.WriteLine(name + "chose" + choice + ".");
        }
    }

}
