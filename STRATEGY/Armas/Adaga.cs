using System;

namespace STRATEGY.Armas
{
    public class Adaga: IArma
    {
        public double Golpear(int forca){ 
            Console.WriteLine("Golpe com adaga");
            return forca * 6;
        }
    }
}