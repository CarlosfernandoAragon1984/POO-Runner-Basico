using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ejercicio_2
{
    static class ConvalidarDatos
    {
        public static string PedirStrNoVac(string mensaje)
        {
            string valor;
            do
            {
                Console.WriteLine(mensaje);
                valor = Console.ReadLine().ToUpper();
                if (valor == "")
                {
                    Console.WriteLine("No puede ser vacio");

                }
            } while (valor == "");
            return valor;
        }

        public static long PedirLong(string mensaje, long min, long max)
        {
            long valor;
            bool Valido = false;
            string mensaError = "Debe ingresar un valor entre " + min + " y " + max;
            do
            {
                Console.WriteLine(mensaje);
                if (!long.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine(mensaError);
                }
                else
                {
                    if (valor < min || valor > max)
                    {
                        Console.WriteLine(mensaError);
                    }
                    else
                    {
                        Valido = true;
                    }
                }
            } while (!Valido);
            return valor;
        }
    }
}
