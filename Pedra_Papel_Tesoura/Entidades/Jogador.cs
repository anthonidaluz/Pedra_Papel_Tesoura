using System;
using System.Collections.Generic;
using Pedra_Papel_Tesoura.Entidades;
using System.Text;

namespace Pedra_Papel_Tesoura.Entidades
{
    internal class Jogador
    {
        public string Nome { get; private set; }
        public string Escolha { get; set; }

        public Jogador(string nome)
        {
            Nome = nome;
        }
    }
}
