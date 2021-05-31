using System;

namespace GameAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Eduardo");
            var jogo = new JogoAMS(
                new Jogador1("Eduardo"),
                new Jogador2()
            );
            jogo.IniciarJogo();
        }
    }
}
