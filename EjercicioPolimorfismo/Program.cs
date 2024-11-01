using System;

namespace EjercicioPolimorfismo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Animal miPerro = new Perro();
            Animal miGato = new Gato();

            miPerro.HacerSonido();
            miGato.HacerSonido();

            Console.ReadLine();
        }
    }
}