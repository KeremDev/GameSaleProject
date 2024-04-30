using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concretes
{
    public class SaleManager : ISaleService
    {
        
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine("Tebrikler " + gamer.FirstName + " adlı oyuncu " + game.GameName + " oyunu satın aldı :) " + " Satış Fiyatı: " + game.GamePrice + "TL");
        }

        public void SaleWithCampaign(Gamer gamer, Game game, Campaign campaign) 
        {
            decimal LastPrice = game.GamePrice - (game.GamePrice * campaign.DiscountAmount) / 100;
            Console.WriteLine("Tebrikler " + gamer.FirstName + " adlı oyuncu " + game.GameName + " oyunu satın aldı :) " + "Kampanya Adı : " + campaign.campaignName + " İndirimli Fiyat : " + LastPrice + "TL");

        }
    }
}
