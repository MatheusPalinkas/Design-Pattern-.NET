using System;

namespace STRATEGY.Armas
{
    public class SemArma: IArma
    {
        public double Golpear(int forca) {
            Console.WriteLine("Golpe sem arma");
            return forca;
        }
    }
}