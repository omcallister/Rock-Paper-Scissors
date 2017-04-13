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
        public static string UserPick()
        {
           
            Roshambo u = new Roshambo();
            int input = int.Parse(Console.ReadLine());          
            
            return u.GetRoshambo(input);
        }  
    }
}
