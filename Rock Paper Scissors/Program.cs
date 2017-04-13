using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string userAction;
            Random rando = new Random();
            Roshambo r = new Roshambo();

            Console.WriteLine("which person would you like to play against?");
            Console.WriteLine("Rocky or Sasha");
            input = Console.ReadLine().ToLower();

            if (input == "rocky")
            {
                Console.WriteLine("enter 1 for Rock, 2 for Paper, and 3 for Scissors");
                userAction = UserPlayer.UserPick();
                Console.WriteLine($"You threw {userAction}!");
                IPlayer p = new RockPlayer("Rocky");
                Console.WriteLine(p.GetName() + " throws out rock" );

                switch (a)
                {
                    case 1:
                        switch (userAction)
                        {
                            case 1:
                                Console.WriteLine($"You threw {userAction}!");
                                Console.WriteLine(p.GetName() + " throws out rock");
                                Console.WriteLine("you win!");
                                break;
                        }
                }
                
            }
            else if (input == "sasha")
            {
                Console.WriteLine("enter 1 for Rock, 2 for Paper, and 3 for Scissors");
                userAction = UserPlayer.UserPick();
                Console.WriteLine($"You threw {userAction}!");
                IPlayer p2 = new RandPlayer("Sasha", rando);
                Console.WriteLine(p2.GetName() + " throws out " + p2.GenerateRoshambo());
                rando.Next();
            }
            else
            {
                Console.WriteLine("invalid input. try again.");
            }
        }
    }
}
