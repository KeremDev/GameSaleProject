using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GameSaleProject.Concretes
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool GamerCheck(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.FirstName == "Kerem" && gamer.LastName == "Nazario" && gamer.IdentityNo == "22222222222" && gamer.DateOfBirth == 1988)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}



