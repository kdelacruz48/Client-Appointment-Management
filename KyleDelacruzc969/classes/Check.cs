using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleDelacruzc969.classes
{

    

    class Check
    {


        public static bool isPhone = true;


        public static bool isNumber(string phone) // used to check if phone number consists of numbers and "-"
        {

            isPhone = true;
            char[] chars = phone.ToArray();        // LAMBDA used to check if phone number consists of numbers, and '-'
            List <char> l = chars.ToList();        // This was simpler than my original implimentation
            l.ForEach(item =>
            {
                if(item == '-')
                {
                    isPhone = true;
                }

                else if (item < '0' || item > '9')
                {

                    isPhone = false;
                    
                }
            });

            return isPhone;
            
        }
    }
}
