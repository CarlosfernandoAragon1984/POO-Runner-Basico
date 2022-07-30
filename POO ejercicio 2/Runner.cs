using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ejercicio_2
{
    class Runner
    {
        private static decimal totalKm = 0;
        private static decimal kmRecorrido = 0; 
        private static decimal objetivoKm = 0;
        public static void  GuardarSesion(decimal recorridokm)
        {
            kmRecorrido = recorridokm;
            totalKm = totalKm + kmRecorrido;
        }
        public static void Objetivos(decimal kmOjetivo)
        {
            objetivoKm = kmOjetivo;
        }
        public static void Estadisticas()
        {
           
           
            if (totalKm > objetivoKm)
            {
                Console.WriteLine("Estadistica: \n" + "\t Objetivo en Kms Totales: " + objetivoKm + "\t "+ "Realizados : " 
                    + totalKm + "\tObjetivo Cumplido");
              

            }
            else
            {
                Console.WriteLine("Estadistica \n" + "Objetivo en Kms Totales: " + objetivoKm + "\t ");
                Console.WriteLine("Realizados : " + totalKm );
            }
        }

    }
}
