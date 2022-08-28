using GameStoreProject.Abstract;
using GameStoreProject.Entities;
using GameStoreProject.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(gamer.IdentityNumber, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear);


        }
    }
}
