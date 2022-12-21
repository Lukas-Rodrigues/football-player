using football_player.Models;
using System;
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
            DateTime entrada =  PlayerService.DateNascimento();
            Console.WriteLine(entrada);
            Console.WriteLine(PlayerService.CalcularIdade(entrada)); 
            Console.ReadKey();
        }
    }
}
