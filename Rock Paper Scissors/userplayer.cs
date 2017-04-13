using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    
    public class UserPlayer : IPlayer
    {
        string name;
        string response;

        public string GenerateRoshambo()
        {
            /*Console.WriteLine("");
            string userInput = Console.ReadLine();
            userInput = response;*/
            return response;

        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string n)
        {
            name = n;
        }
        public static int UserPick()
        {
            Roshambo u = new Roshambo();
            int input = int.Parse(u.GetRoshambo());
            return input;
        }  
    }
}
