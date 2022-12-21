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
            while (opcao != 6)
            {
                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("===       Atendimento       ===");
                Console.WriteLine("===1 - Cadastrar De Jogador ===");
                Console.WriteLine("=== 2 - Listar Contas        ===");
                Console.WriteLine("=== 3 - Remover Conta        ===");
                Console.WriteLine("=== 4 - Ordenar Contas       ===");
                Console.WriteLine("=== 5 - Pesquisar Conta      ===");
                Console.WriteLine("=== 6 - Sair do Sistema      ===");
                Console.WriteLine("===============================");
                Console.WriteLine("\n\n");
                Console.WriteLine("Digite a opção que você tem interesse: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                Console.WriteLine()


                }




            }




















                Console.ReadKey();
        }
    }
}
