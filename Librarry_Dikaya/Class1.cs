using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarry_Dikaya
{
    public class Player
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Player(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public void Show()
        {
            Console.WriteLine($"Имя: {Name}, Описание: {Description}");
        }
    }
    public class Team
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Player> players;

        public Team(string name, string address)
        {
            Name = name;
            Address = address;
            players = new List<Player>();
        }

        public void AddPlayers(Player player)
        {
            players.Add(player);
        }
        public void Show()
        {
            Console.WriteLine($"Команда: {Name}, Адрес: {Address}");
        }


        public void ShowAll()
        {
            Show();
            Console.WriteLine("Игроки в команде: ");
            foreach (var player in players.OrderBy(p => p.Name))
            {
                player.Show();

            }

        }
    }
}
