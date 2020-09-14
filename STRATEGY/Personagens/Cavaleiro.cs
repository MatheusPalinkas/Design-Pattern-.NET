using System;

namespace STRATEGY.Personagens
{
    public class Cavaleiro : Personagem
    {
        public Cavaleiro(string nome): base($"Sir. {nome}", 2, 10){}

        public override void Gritar(){
            Console.WriteLine("Pela hora e gloria do rei !!");
        }
    }
}