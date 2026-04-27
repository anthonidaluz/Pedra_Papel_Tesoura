using System;
using System.Collections.Generic;
using Pedra_Papel_Tesoura.Entidades;
using System.Text;

namespace Pedra_Papel_Tesoura.Entidades
{
    internal class Jogo
    {
        public string DeterminarVencedor(string escolhaJogador, string escolhaComputador)
        {
            if (escolhaJogador == escolhaComputador)
            {
                return "EMPATE";
            }
            else if (
                (escolhaJogador == "pedra" && escolhaComputador == "tesoura") ||
                (escolhaJogador == "papel" && escolhaComputador == "pedra") ||
                (escolhaJogador == "tesoura" && escolhaComputador == "papel")
                )
            {
                return "JOGADOR";
            }
            else
            {
                return "COMPUTADOR";
            }


        }
    }

}