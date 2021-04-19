using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Exceptions.Clases
{
    class MyExceptions : Exception
    {
        
        public MyExceptions(string mensaje) : base($"Error. {mensaje}")
        {

        }

        public MyExceptions() : base($"Error")
        {

        }
    }
}
