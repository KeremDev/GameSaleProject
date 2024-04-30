using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concretes
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.GamerCheck(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + "isimli oyuncu eklendi !");
            }
            else
            {
                Console.WriteLine("Kimlik Doğrulaması Başarılı Değil - Oyuncu Eklenemedi !!!" + " - " +gamer.FirstName );
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + "isimli oyuncu silindi !");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + "isimli oyuncu Güncellendi !");
        }

      
    }
}
