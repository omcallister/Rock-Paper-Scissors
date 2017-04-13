using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class RandPlayer : IPlayer
    {
        private string name;
        Random rando;

        public RandPlayer(string n, Random r)
        {
            name = n;
            rando = r;
        }
        public string GenerateRoshambo()
        {
            int pick = rando.Next(0, 3);
            Roshambo r = new Roshambo();
            string result = r.GetRoshambo(pick);
            return result;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string n)
        {
            name = n;
        }
    }
}
