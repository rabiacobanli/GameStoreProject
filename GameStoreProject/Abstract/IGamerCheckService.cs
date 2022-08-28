using GameStoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject.Abstract
{
    public interface IGamerCheckService
    {

        bool CheckIfRealPerson(Gamer gamer);
    }
}
