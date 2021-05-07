using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TPEntityFramework.Logic
{
    public static class Validations
    {
        public static int NumberValidation(string num)
        {
            int numParse;
            if (int.TryParse(num, out numParse))
            {
                return numParse;
            }

            return 0;
        }

        public static int ConfirmValidation(string confirm)
        {
            if (confirm != "s" && confirm != "n")
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }
    }
}
