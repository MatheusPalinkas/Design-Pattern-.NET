using System;

namespace STRATEGY.Armas
{
  public class Espada : IArma
  {
      public double Golpear(int forca) {
        Console.WriteLine("Golpe com espada");
        return forca * 7;
      }
  }
}