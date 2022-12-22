using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace football_player.Models
{
    public class PlayerService
    {
        public static List<Player> List_players = new List<Player>();
        public static void CadastrarPlayer()
        {
            Player player = new Player();
            Console.Write("Digite o nome do jogador: ");
            player.Name = Console.ReadLine();
            player.DateNascimento();
            Console.Write("Digite sua altura: ");
            player.Altura = float.Parse(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            player.Peso = float.Parse(Console.ReadLine());
            Console.Write("Digite a posição do jogador: ");
            player.Position = Console.ReadLine();
            player.Idade = player.CalcularIdade();
            player.Aposentadoria = player.TempoAposentar(player);
            List_players.Add(player);
            Console.WriteLine("Jogador cadastrado com sucesso!!!");
            Console.ReadKey();


        }


        public static void Exibir()
        {
            foreach (Player item in List_players)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"Nome do jogador: {item.Name}");
                Console.WriteLine($"Data de nascimento do jogador: {item.DateTime}");
                Console.WriteLine($"Altura do jogador: {item.Altura}");
                Console.WriteLine($"Peso do jogador: {item.Peso}");
                Console.WriteLine($"idade do jogador: {item.Idade} anos");
                Console.WriteLine($"Quantidade de tempo para se aposentar:{item.Aposentadoria} anos");
                Console.WriteLine("------------------------------------------\n");
                Console.ReadKey();
            }
        }


    }
}
