using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        //public int CampaignId { get; set; }
        public string GameName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
