using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maúlla: ¡Miau!");
        }
    }
}