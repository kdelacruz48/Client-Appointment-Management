using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyleDelacruzc969.classes
{
    class Checks
    {

		public static bool isNumber(string phone)
		{

			foreach (var number in phone)
			{
				if (number < '0' || number > '9')
				{
					if (number + string.Empty == "-")
					{
						continue;
					}

					else

						return false;
				}


			}
			return true;
		}
	}
}
