using GameStoreProject.Abstract;
using GameStoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Added: "+campaign.CampaignName);
        }

        public void Apply(Campaign campaign, Game game)
        {
            Console.WriteLine($"Applied {campaign.CampaignName} campaign for {game.GameName} game.");
          
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Deleted: " + campaign.CampaignName);

        }
    }
}
