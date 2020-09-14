using System;

namespace STRATEGY.Personagens
{
    public class Viking : Personagem
    {
        public Viking(string nome): base(nome, 7, 2){}

        public override void Gritar(){
            Console.WriteLine("GRRRRRRRRRRRRRRRR !!!");
        }
    }
}