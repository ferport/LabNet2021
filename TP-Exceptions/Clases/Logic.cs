using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Exceptions.Clases
{
    class Logic
    {
        public static void ArrojarExcepsion()
        {
            string cadena = "HolaMundo";
            cadena.Substring(cadena.Length + 1);
        }

        public static void ArrojarMyException(string error)
        {
            throw new MyExceptions(error);
        }
    }
}
