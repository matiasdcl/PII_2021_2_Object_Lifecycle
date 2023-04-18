//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            int counter_name = 1;
            for (int i = 1; i == 100; i++)
            {
                var Train = new Train($"{counter_name}");
                counter_name++;
            }
            //Console.Write($"there are {Train.TrainAmount} trains");
        }
    }
}