using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace football_player.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string Position { get; set;}
        public DateTime DateTime { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public int  Idade { get; set; }
        public int Aposentadoria { get; set; }




        public int TempoAposentar(Player player)
        {
            int idade = CalcularIdade();

            if (idade < 40 && player.Position.ToUpper() == "DEFESA")
            {
                idade = 40 - idade;

            }
            if (idade < 38 && player.Position.ToUpper() == "MEIO CAMPO")
            {
                idade = 38 - idade;

            }
            if (idade < 35 && player.Position.ToUpper() == "ATACANTE")
            {
                idade = 35 - idade;


            }
            return idade;

        }

        public int CalcularIdade()
        {
            DateTime dataatual = DateTime.Now;
            return dataatual.Year - DateTime.Year;
        }
        public void DateNascimento()
        {
            int dia, mes, ano;
            Console.Write("Digite o dia de nascimento: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Digite o mês de nascimento: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano de nascimento: ");
            ano = int.Parse(Console.ReadLine());
            DateTime =  new DateTime(ano, mes, dia);


        }

      
    }
}
