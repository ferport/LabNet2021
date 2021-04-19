using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Exceptions.Clases
{
    class PruebaDeExceptions
    {

        public static void DivisionPorCero(int num)
        {
            double resultado;

            try
            {
                resultado = num / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Termino la operacion");
            }

        }

        public static void Division(string dividendo, string divisor)
        {
            double resultado = 0;
            int operando1 = 0;
            int operando2 = 0;
            int flag = 0;
            try
            {
                operando1 = int.Parse(dividendo);
                operando2 = int.Parse(divisor);
            }
            catch (Exception)
            {
                Console.WriteLine("No ha ingresado un numero valido");
                flag = 1;
            }

            if (flag == 0)
            {
                try
                {
                    resultado = operando1 / operando2;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Solo Chuck Norris divide por cero!");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (resultado != 0)
                    {
                        Console.WriteLine($"El resultado de la division es: {resultado}");
                    }
                }
            }

        }
    }
}
