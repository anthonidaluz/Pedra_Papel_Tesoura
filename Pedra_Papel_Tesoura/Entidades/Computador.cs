using System;
using System.Collections.Generic;
using Pedra_Papel_Tesoura.Entidades;
using System.Text;

namespace Pedra_Papel_Tesoura.Entidades
{
    internal class Computador
    {
        public string Escolha { get; set; }

        private string[] opcoes = { "pedra", "papel", "tesoura" };

        private Random random;

        public Computador()
        {
            random = new Random();
        }

        public void SortearJogada()
        {
            int indice = random.Next(0, 3);
            Escolha = opcoes[indice];
        }
    }
}
