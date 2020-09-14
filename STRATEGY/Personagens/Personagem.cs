using System;
using STRATEGY.Armas;

namespace STRATEGY.Personagens
{
    public abstract class Personagem
    {
        public string Nome { get; private set; }
        public int Forca { get; private  set; }
        public int Resistencia { get; private set; }
        public int Vida { get; private set;}
        private IArma _arma = new SemArma();

        public Personagem(string nome, int forca, int resistencia)
        {
            Nome = nome;
            Forca = forca;
            Resistencia = resistencia;
            Vida = 100;
        }

        public void SofrerDano(int dano){
            int pontosVidaPerdidos = dano - Resistencia >= 0 ? dano - Resistencia : 0;
            Console.WriteLine($"{Nome} pedeu {pontosVidaPerdidos} pontos de vida");
            Vida -= pontosVidaPerdidos;
        }

        public void Atacar(Personagem inimigo){
            Console.WriteLine($"{Nome} atacou {inimigo.Nome}");
            inimigo.SofrerDano((int)GolpeComArma(Forca));
        }

        public abstract void Gritar();
    
        public void TrocarArma(IArma novaArma) => _arma = novaArma;

        protected double GolpeComArma(int forca){
            return _arma.Golpear(forca);
        }
    }
}