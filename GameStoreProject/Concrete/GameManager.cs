using GameStoreProject.Abstract;
using GameStoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Added: "+game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Deleted: " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Updated: " + game.GameName);
        }
    }
}
