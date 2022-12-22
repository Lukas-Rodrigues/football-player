using football_player.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football_player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 3)
            {
                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("===       Atendimento       ===");
                Console.WriteLine("=== 1 - Cadastrar De Jogador ===");
                Console.WriteLine("=== 2 - Listar Jogadores    ===");
                Console.WriteLine("=== 3 - Sair do Sistema     ===");
                Console.WriteLine("===============================");
                Console.WriteLine("\n\n");
                Console.Write("Digite a opção que você tem interesse: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        PlayerService.CadastrarPlayer();
                        break;
                    case 2:
                        PlayerService.Exibir();
                        break;
                    case 3:
                        opcao = 3;
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
