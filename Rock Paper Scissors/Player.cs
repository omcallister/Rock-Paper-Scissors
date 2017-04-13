using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    interface IPlayer
    {
        string GetName();
        void SetName(string n);
        string GenerateRoshambo();
    }
}
