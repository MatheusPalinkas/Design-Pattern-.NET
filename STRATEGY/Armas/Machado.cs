using System;

namespace STRATEGY.Armas
{
    public class Machado: IArma
    {
        public double Golpear(int forca) {
            Console.WriteLine("Golpe com machado");
            return forca * 8;
        }
    }
}