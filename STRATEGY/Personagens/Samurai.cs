using System;

namespace STRATEGY.Personagens
{
    public class Samurai : Personagem
    {
        public Samurai(string nome): base(nome, 5, 5){}

        public override void Gritar(){
            Console.WriteLine("Pela hora e pelo senhor feudal !!");
        }
    }
}