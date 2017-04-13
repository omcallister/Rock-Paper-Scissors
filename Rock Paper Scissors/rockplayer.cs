using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class RockPlayer : IPlayer
    {
        string name; 
        
        public RockPlayer(string n)
        {
            name = n;
        } 
        public string GetName()
        {
            return name;
        }
        public void SetName(string n)
        {
            name = n;
        }
        public string GenerateRoshambo()
        {
            Roshambo r = new Roshambo();
            string result = r.GetRoshambo(0);
            return result;
        }
    }
}
