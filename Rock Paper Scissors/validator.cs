using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Validator
    {
        public static int UserInput()
        {
            int result;
            ConsoleKeyInfo UserInput = Console.ReadKey(true);

            if (int.TryParse(UserInput.KeyChar.ToString(), out result)
                && result > 0
                && result <= 3)
            {
                Console.WriteLine();
                return result;
            }
            else
            {
                Console.WriteLine("Nope! Try again.");
                return Validator.UserInput();
            }
        }
    }
}
