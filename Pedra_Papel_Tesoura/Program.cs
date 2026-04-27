using System;
using Pedra_Papel_Tesoura.Entidades;

namespace Pedra_Papel_Tesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador1 = new Jogador("Você");
            Computador bot = new Computador();
            Jogo arbitro = new Jogo();

            bool jogarNovamente = true;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Bem-vindo ao jogo Pedra, Papel e Tesoura!");
                Console.WriteLine("-------------------------------------------");
                Console.ResetColor();

                Console.Write("Escolha Pedra, Papel ou Tesoura: ");

                jogador1.Escolha = Console.ReadLine().Trim().ToLower();

                if (jogador1.Escolha != "pedra" && jogador1.Escolha != "papel" && jogador1.Escolha != "tesoura")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Opção inválida! Pressione ENTER para tentar novamente.");
                    Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }

                bot.SortearJogada();

                Console.WriteLine("\n===========================================");
                Console.WriteLine($"{jogador1.Nome} escolheu      : {jogador1.Escolha.ToUpper()}");
                Console.WriteLine($"Computador escolheu: {bot.Escolha.ToUpper()}");
                Console.WriteLine("===========================================\n");

                string resultado = arbitro.DeterminarVencedor(jogador1.Escolha, bot.Escolha);

                if (resultado == "EMPATE")
                {
                    Console.WriteLine("RESULTADO: EMPATE! Ninguém ganhou.");
                }
                else if (resultado == "JOGADOR")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("RESULTADO: VOCÊ VENCEU! ");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("RESULTADO: O COMPUTADOR VENCEU! ");
                    Console.ResetColor();
                }

                Console.Write("\nDeseja jogar novamente? (S/N): ");
                string resposta = Console.ReadLine().Trim().ToUpper();

                if (resposta != "S")
                {
                    jogarNovamente = false;
                    Console.WriteLine("\nSaindo do jogo... Obrigado por jogar!");
                }

            } while (jogarNovamente);
        }
    }
}