using Librarry_Dikaya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Team team = new Team("Лисы", "Москва");

                team.AddPlayers(new Player("Кевин Дэй", "Нападающий"));
                team.AddPlayers(new Player("Ники Хэмик", "Защитник"));
                team.AddPlayers(new Player("Эндрю Джостен", "Голкипер"));
                team.AddPlayers(new Player("Нил Джостен", "Нападающий"));
                team.AddPlayers(new Player("Сет Горден", "Защитник"));

                team.ShowAll();
                Console.WriteLine("\nРаботу выполнила Дикая");
                Console.ReadKey();
            }
        }
}
