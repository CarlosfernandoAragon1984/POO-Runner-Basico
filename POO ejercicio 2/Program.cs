using System;

namespace POO_ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
           const string FijarObjetivo = "O";
           const string AgregarSesion = "A";
           const string Estadisticas = "E";
           const string Salir = "S";
            decimal KmTotalRecorrido = 0;
            decimal TotalOjetivoKm = 0;

            string Opcion = "";
            do
            {
                Console.WriteLine("Menú Principal");
                Console.WriteLine(FijarObjetivo+": Fijar Objetivo ");
                Console.WriteLine(AgregarSesion+": Agregar Sesión");
                Console.WriteLine(Estadisticas+": Estadistica");
                Console.WriteLine(Salir+": Salir");
                
                Opcion = ConvalidarDatos.PedirStrNoVac("Ingrese una opción");

                switch (Opcion)
                {
                    case FijarObjetivo:
                        TotalOjetivoKm = ConvalidarDatos.PedirLong("Ingrese el objetivo",1,500);
                        Runner.Objetivos(TotalOjetivoKm);
                        break;
                    case AgregarSesion:
                        KmTotalRecorrido = ConvalidarDatos.PedirLong("Agrege su Sesión", 1, 50);
                        Runner.GuardarSesion(KmTotalRecorrido);
                        break;
                    case Estadisticas:
                        Runner.Estadisticas();
                        break;
                    case Salir:
                        break;
                    default:
                        Console.WriteLine("La opción no es valida");
                        break;


                }
            } while (Opcion != Salir);

            Console.ReadKey();

        }
    }
}
