using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Punto 1
            #region
            Console.WriteLine("Ingrese un numero");
            string num = Console.ReadLine();

            Clases.PruebaDeExceptions.DivisionPorCero(int.Parse(num));
            Console.ReadKey();
            Console.Clear();
            #endregion

            //Punto 2
            #region
            Console.WriteLine("Ingrese un dividendo");
            string dividendo = Console.ReadLine();

            Console.WriteLine("Ingrese un divisor");
            string divisor = Console.ReadLine();

            Clases.PruebaDeExceptions.Division(dividendo,divisor);
            Console.ReadKey();
            Console.Clear();
            #endregion

            //Punto 3
            #region
            try
            {
                Clases.Logic.ArrojarExcepsion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
            Console.ReadKey();
            Console.Clear();
            #endregion

            //Punto 4
            #region
            try
            {
                Clases.Logic.ArrojarMyException("Mensaje de error");
            }
            catch (Clases.MyExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
            #endregion
        }
    }
}
