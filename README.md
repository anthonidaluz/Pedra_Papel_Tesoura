# 🎮 Pedra, Papel e Tesoura (Jokenpô)

Programa desenvolvido no curso da Academia do Programador

<img width="1080" height="600" alt="VsDebugConsole_LTaZqKor41" src="https://github.com/user-attachments/assets/95b84cde-52aa-4980-a666-6c3b8dec065c" />

O projeto está estruturado em uma arquitetura de domínio limpa, com as seguintes entidades:

* **`Jogador.cs`**: Representa o usuário. Responsável por armazenar seu estado e escolha.
* **`Computador.cs`**: Representa o oponente (Bot). Possui inteligência própria usando a classe `Random` para sortear sua jogada de forma independente.
* **`Jogo.cs`**: Atua como o **Árbitro** da partida. É uma classe puramente lógica que recebe as jogadas, processa as regras de vitória/derrota/empate e devolve o veredito, sem acoplamento com a interface gráfica.
* **`Program.cs`**: Atua como o motor de apresentação (UI). Gerencia o loop da partida (`do/while`), coleta os inputs do teclado e colore a saída no terminal com base no resultado do árbitro.

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** .NET (Console Application)
* **Paradigma:** Orientação a Objetos (POO)
