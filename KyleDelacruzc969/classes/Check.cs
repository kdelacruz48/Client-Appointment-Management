using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleDelacruzc969.classes
{
    class Check
    {
        public static bool isNumber(string phone) // used to check if phone number consists of numbers and "-"
        {
            foreach (var number in phone)
            {
                if (number < '0' || number > '9')
                {
                    if (number + string.Empty == "-")
                    {
                        continue;
                    }
                    return false;
                }

            }
            return true;
        }
    }
}
