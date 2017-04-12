using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class randplayer
    {
        public static void RandPlayer()
        {
            for (int i = 0; i < 1; i++)
            {
                Random rnd = new Random();
                int chance = rnd.Next(1, 4);
                Console.WriteLine("enter 1 for paper, 2 for rock, 3 for scissors");
                string userInput = Console.ReadLine();
                int a = int.Parse(userInput);

                switch (a)
                {
                    case 1:
                        switch (chance)
                        {
                            case 1:
                                Console.WriteLine("You: paper");
                                Console.WriteLine("Computer: paper");
                                Console.WriteLine("Draw");
                                break;
                            case 2:
                                Console.WriteLine("You: paper");
                                Console.WriteLine("Computer: rock");
                                Console.WriteLine("You won!");
                                break;
                            case 3:
                                Console.WriteLine("You: paper");
                                Console.WriteLine("Computer: scissors");
                                Console.WriteLine("You lost!");
                                break;
                        }
                        break;
                    case 2:
                        switch (chance)
                        {
                            case 1:
                                Console.WriteLine("You: rock");
                                Console.WriteLine("Computer: rock");
                                Console.WriteLine("Draw");
                                break;
                            case 2:
                                Console.WriteLine("You: rock");
                                Console.WriteLine("Computer: scissors");
                                Console.WriteLine("You won!");
                                break;
                            case 3:
                                Console.WriteLine("You: rock");
                                Console.WriteLine("Computer: paper");
                                Console.WriteLine("You lost!");
                                break;
                        }
                        break;
                    case 3:
                        switch (chance)
                        {
                            case 1:
                                Console.WriteLine("You: scissors");
                                Console.WriteLine("Computer: scissors");
                                Console.WriteLine("Draw");
                                break;
                            case 2:
                                Console.WriteLine("You: scissors");
                                Console.WriteLine("Computer: paper");
                                Console.WriteLine("You win!");
                                break;
                            case 3:
                                Console.WriteLine("You: scissors");
                                Console.WriteLine("Computer: rock");
                                Console.WriteLine("You lost!");
                                break;
                        }
                        break;
                }
            }
        }
    }
}
