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

            Random rando = new Random();
            Roshambo r = new Roshambo();

            Console.WriteLine("which person would you like to play against?");
            Console.WriteLine("Rocky or Sasha");
            input = Console.ReadLine().ToLower();

            if (input == "rocky")
            {
                UserPlayer.UserPick();

                IPlayer p = new RockPlayer("Rocky");
                Console.WriteLine(p.GetName() + " throws out " + p.GenerateRoshambo());
                
            }
            else if (input == "sasha")
            {
                IPlayer p2 = new RandPlayer("Vicky", rando);
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
