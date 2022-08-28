using GameStoreProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Added to db: " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted: " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated: " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
