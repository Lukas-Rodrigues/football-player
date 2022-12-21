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
        public List<Player> players = new List<Player>();

        public static DateTime DateNascimento()
        {
            int dia, mes, ano;
            Console.Write("Digite o dia de nascimento: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Digite o mês de nascimento: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());
            return new DateTime(ano, mes, dia);


        }

        public static int CalcularIdade(DateTime Nascimento)
        {
            DateTime dataatual = DateTime.Now;
            return dataatual.Year - Nascimento.Year;
        }


        public void CadastrarPlayer()
        {
            Player player = new Player();
            Console.Write("Digite o nome do jogador: ");
            player.Name = Console.ReadLine();
            player.DateTime = DateNascimento();
            Console.Write("Digite sua altura: ");
            player.Altura = float.Parse(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            player.Peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a posição do jogador: ");
            player.Position = Console.ReadLine();


        }
       




    }
}
