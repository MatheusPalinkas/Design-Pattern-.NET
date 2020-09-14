using System;
using STRATEGY.Personagens;
using STRATEGY.Armas;

namespace STRATEGY
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem heroi;
            var inimigo = new Inimigo();

            Apresentacao();
            InimigoChegando(inimigo);
            heroi = EscolherPersonagem();
            Luta(heroi, inimigo);
            FimDeJogo(heroi);
        }

        static void Apresentacao(){
            Console.WriteLine("Bem vindo ao RPG-STRATEGY");
            for (int i = 0; i < 50;Console.Write("-", i++));
            Console.WriteLine();
            Console.WriteLine("Escolha um personagem e lute contra o perverso inimigo da repetição de código");
            Console.WriteLine("O vença usando o padrão STATEGY e sua capacidade de extrair o comportamento variante");
            Console.WriteLine("Precione Enter para continuar");
            for (int i = 0; i < 50;Console.Write("-", i++));    
            Console.ReadLine();
        }

        static void InimigoChegando(Personagem inimigo){
            Console.Clear();
            Console.WriteLine("Inimigo chegando...");
            Console.WriteLine("Ele aparece abre a boca e grita");
            inimigo.Gritar();
            Console.WriteLine("Vamos lutar contra esse inimigo");
            Console.WriteLine("Precione Enter para continuar");
            Console.ReadLine();
        }

        static Personagem EscolherPersonagem(){
            Console.Clear();

            string nome; 
            int tipoHeroi;
            Personagem personagem = null;

            Console.WriteLine("Chegou a hora escolha um nome para o seu heroi");
            nome =  Console.ReadLine();

            do{
                try{
                    Console.WriteLine("Agora escolha o tipo do seu heroi ");
                    Console.WriteLine("Opções: 1 - cavaleiro 2 - samurai 3 - viking");
                    tipoHeroi = int.Parse(Console.ReadLine());

                    if(1 == tipoHeroi)
                        personagem =  new Cavaleiro(nome);
                    else if(2 == tipoHeroi)    
                        personagem = new  Samurai(nome);
                    else if(3 == tipoHeroi)
                        personagem = new  Viking(nome);
                    else
                        Console.WriteLine("Erro para o tipo de heroi só são aceitos valores entre 1 e 3");
                }
                catch(FormatException e){
                    Console.WriteLine("Erro para o tipo de heroi só são aceitos valores inteiros");
                }
            }while(personagem == null);

            return personagem;
        }

        static void Luta(Personagem heroi, Personagem inimigo){
            int rodada = 1;
            do{
                Console.Clear();
                Console.WriteLine($"Rodada: {rodada}");
                Console.WriteLine($"Vida do {heroi.Nome}: {heroi.Vida} | Vida da {inimigo.Nome}: {inimigo.Vida}");

                
                inimigo.Atacar(heroi);
                for (int i = 0; i < 50;Console.Write("-", i++));
                Console.WriteLine();
                Console.WriteLine("Precione Enter para continuar");
                Console.ReadLine();

                Console.Clear();
                heroi.TrocarArma(EscolherArma(heroi));
                Console.Clear();
                heroi.Atacar(inimigo);

                 for (int i = 0; i < 50;Console.Write("-", i++));
                Console.WriteLine();
                Console.WriteLine("Precione Enter para continuar");
                Console.ReadLine();
                rodada++;
            }while(heroi.Vida > 0 && inimigo.Vida > 0 );
        }

        static IArma EscolherArma(Personagem personagem){
            IArma arma = null;
            int tipoArma;

            do{
                try{
                    Console.WriteLine("Rapido escolha uma arma ");
                    Console.WriteLine("Opções: 1 - Adaga | 2 - Espada | 3 - Machado | 4 - Sem Arma");
                    tipoArma = int.Parse(Console.ReadLine());

                    if(1 == tipoArma)
                        arma =  new Adaga();
                    else if(2 == tipoArma)    
                        arma = new  Espada();
                    else if(3 == tipoArma)
                        arma = new  Machado();
                    else if(4 == tipoArma)
                        arma = new  SemArma();
                    else
                        Console.WriteLine("Erro para o tipo de heroi só são aceitos valores entre 1 e 3");
                }
                catch(FormatException e){
                    Console.WriteLine("Erro para a arma só são aceitos valores inteiros");
                }
            }while(arma == null);

            return arma;
        }
        
        static void FimDeJogo(Personagem heroi){
            Console.Clear();
            Console.WriteLine("Fim de jogo");

            if(heroi.Vida <= 0){
                Console.WriteLine("Pena não foi dessa vez");
                Console.WriteLine("Precione Enter finalizar");
                Console.ReadLine();
            }
            else{
                Console.WriteLine("Parabens vc venceu a repetição de código");
                Console.WriteLine("Precione Enter dar um grito de guerra");
                Console.ReadLine();
                heroi.Gritar();
                Console.WriteLine("Precione Enter finalizar");
                Console.ReadLine();
            }
        }
    }
}
