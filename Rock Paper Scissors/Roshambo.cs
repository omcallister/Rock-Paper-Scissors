using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class Roshambo
    {
        private List<string> rosh;
        public Roshambo()
        {
            rosh = new List<string>();
            rosh.Add("Rock");
            rosh.Add("Paper");
            rosh.Add("Scissors");
        }
        public string GetRoshambo(int index)
        {
            string ro = rosh[index - 1];
            return ro;
        }

        internal void GetRoshambo(int v1, int v2, int v3)
        {
            rosh[0] = "Rock";
            rosh[1] = "Paper";
            rosh[2] = "Scissors";
        }
    }
}
