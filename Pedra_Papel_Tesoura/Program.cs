using System;

namespace Pedra_Papel_Tesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] opcoes = { "pedra", "papel", "tesoura" };
            Random random = new Random();

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

                string escolhaUsuario = Console.ReadLine().Trim().ToLower();

                if (escolhaUsuario != "pedra" && escolhaUsuario != "papel" && escolhaUsuario != "tesoura")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Opção inválida! Pressione ENTER para tentar novamente.");
                    Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }

                int indiceComputador = random.Next(0, 3);
                string escolhaComputador = opcoes[indiceComputador];

                Console.WriteLine("\n===========================================");
                Console.WriteLine($"Você escolheu      : {escolhaUsuario.ToUpper()}");
                Console.WriteLine($"Computador escolheu: {escolhaComputador.ToUpper()}");
                Console.WriteLine("===========================================\n");

                if (escolhaUsuario == escolhaComputador)
                {
                    Console.WriteLine("RESULTADO: EMPATE! Ninguém ganhou.");
                }
                else if (
                    (escolhaUsuario == "pedra" && escolhaComputador == "tesoura") ||
                    (escolhaUsuario == "papel" && escolhaComputador == "pedra") ||
                    (escolhaUsuario == "tesoura" && escolhaComputador == "papel")
                )
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