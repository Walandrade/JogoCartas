using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCartas.cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Seja bem vindo(a)! Escolha uma das opções:");
            Console.WriteLine("1 - 1P vs Computador");
            Console.WriteLine("2 - 1P vs 2P");
            Console.WriteLine("3 - Sair do jogo");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Você escolheu jogar contra o computador!");
                    Console.Write("informe o seu nome:: ");
                    string nomeJogador = Console.ReadLine();
                    int dena = 10;
                    int energiaComputador = 10;
                    string[] naipes = { "copas", "ouros", "espadas" };
                    Random random = new Random();
                    string[] nomes = { nomeJogador, "Computador" };
                    int jogadorAtual = random.Next(2);
                    Console.WriteLine("O jogador que vai começar é: " + nomes[jogadorAtual]);
                    while (dena > 0 && energiaComputador > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Energia de {nomeJogador}:" + dena);
                        Console.WriteLine($"Energia do computador:" + energiaComputador);
                        Console.WriteLine();
                        Console.WriteLine($"{nomes[jogadorAtual]}, informe uma tecla para sortear as cartas...");
                        Console.ReadKey();
                        string[] cartas = new string[3];
                        for (int i = 0; i < 3; i++)
                        {
                            int indexCarta = random.Next(naipes.Length);
                            cartas[i] = naipes[indexCarta];
                        }
                        Console.WriteLine($"As cartas que o {nomes[jogadorAtual]} tirou foram:{cartas[0]}, {cartas[1]} e {cartas[2]}");
                        if (cartas[0] == cartas[1] && cartas[1] == cartas[2])
                        {
                            Console.WriteLine($"O jogador {nomes[jogadorAtual]} tirou cartas iguais e não perde energia.");
                        }
                        else
                        {
                            Console.WriteLine($"O jogador {nomes[jogadorAtual]} tirou cartas diferentes e perdeu 1 de energia.");
                            if (jogadorAtual == 0)
                            {
                                dena--;
                            }
                            else
                            {
                                energiaComputador--;
                            }
                        }
                        jogadorAtual = (jogadorAtual + 1) % 2;
                    }
                    if (dena == 0)
                    {
                        Console.WriteLine($"{nomeJogador} perdeu todas as energias. computador venceu!");
                    }
                    else
                    {
                        Console.WriteLine($"O computador perdeu todas as energias. Parabéns{nomeJogador}, você venceu!");
                    }
                    break;
                case 2:
                    Console.WriteLine("Você escolheu jogar contra outro jogador!");
                    Console.Write("informe o nome do jogador 1: ");
                    string nomeJogador1 = Console.ReadLine();
                    Console.Write("informe o nome do jogador 2: ");
                    string nomeJogador2 = Console.ReadLine();
                    int Thiago = 10;
                    int Wal = 10;
                    string[] naipesC = { "copas", "ouros", "espadas" };
                    Random randomR = new Random();
                    string[] nomesN = { nomeJogador1, nomeJogador2 };
                    int jogadorAtualUm = randomR.Next(2);
                    Console.WriteLine("O jogador que vai começar é: " + nomesN[jogadorAtualUm]);
                    while (Thiago > 0 && Wal > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Energia de {nomeJogador1}:" + Thiago);
                        Console.WriteLine($"Energia de {nomeJogador2}:" + Wal);
                        Console.WriteLine();
                        Console.WriteLine($"{nomesN[jogadorAtualUm]} pressione uma tecla para sortear as cartas...");
                        Console.ReadKey();
                        string[] cartas = new string[3];
                        for (int i = 0; i < 3; i++)
                        {
                            int indexCarta = randomR.Next(naipesC.Length);
                            cartas[i] = naipesC[indexCarta];
                        }
                        Console.WriteLine($"As cartas que o {nomesN[jogadorAtualUm]} tirou foram: {cartas[0]}, {cartas[1]} e {cartas[2]}");
                        if (cartas[0] == cartas[1] && cartas[1] == cartas[2])
                        {
                            Console.WriteLine($"O jogador {nomesN[jogadorAtualUm]} tirou cartas iguais e não perde energia.");
                        }
                        else
                        {
                            Console.WriteLine($"O jogador {nomesN[jogadorAtualUm]} tirou cartas diferentes e perdeu 1 de energia.");
                            if (jogadorAtualUm == 0)
                            {
                                Thiago--;
                            }
                            else
                            {
                                Wal--;
                            }
                        }
                        jogadorAtualUm = (jogadorAtualUm + 1) % 2;
                    }
                    if (Thiago == 0)
                    {
                        Console.WriteLine($"O jogador {nomeJogador1} perdeu todas as energias.");
                        Console.WriteLine($"O jogador {nomeJogador2} venceu!");
                    }
                    else
                    {
                        Console.WriteLine($"O jogador {nomeJogador2} perdeu todas as energias.");
                        Console.WriteLine($"O jogador {nomeJogador1} é o campeão!");
                    }
                    break;
                case 3:
                    Console.WriteLine("thauuuu ! Até a próxima.");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }

    }
}

