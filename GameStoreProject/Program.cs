using GameStoreProject.Abstract;
using GameStoreProject.Adapters;
using GameStoreProject.Concrete;
using GameStoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            ISalesService orderManager = new OrderManager();
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();
            Gamer gamer1 = new Gamer
            {
                GamerId = 1,
                BirthYear = 1995,
                FirstName = "Rabia",
                LastName = "Çobanlı",
                IdentityNumber = 12345678910
            };


            gamerManager.Add(gamer1);
            //gamerManager.Delete(gamer1);



            Game game = new Game() { GameId = 1, GameName = "LeageuOfLegendsh", UnitPrice = 100 };
            gameManager.Add(game);

            Campaign campaign = new Campaign() { CampaignId = 1, CampaignName = "FiftyPercentOff" };

            campaignManager.Add(campaign);

            orderManager.Sell(game, gamer1);
            campaignManager.Apply(campaign, game);

      




            Console.ReadLine();
        }
    }
}
