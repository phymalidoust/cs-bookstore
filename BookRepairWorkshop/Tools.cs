using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRepairWorkshop
{
    class Tools
    {
        public static string GenerateRandomNumber()
        {
            //Generates unique ID
            Guid randNum = Guid.NewGuid();
            return randNum.ToString();
        }
    }
}
