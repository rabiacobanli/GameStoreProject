using GameStoreProject.Abstract;
using GameStoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject.Concrete
{
    public class OrderManager : ISalesService
    {
        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine("Sold to "+gamer.FirstName+" "+gamer.LastName+" "+ game.GameName+ " game." );
        }
    }
}
