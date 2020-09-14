using System;

namespace STRATEGY.Personagens
{
    public class Inimigo: Personagem
    {
        public Inimigo(): base("Repetição de código", 10, 10){}

        public override void Gritar(){
            Console.WriteLine("Depois é só refatorar!!");
        }
    }
}