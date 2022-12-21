using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace football_player.Models
{
    public class PlayerService
    {
        static Player player;
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
    }
}
