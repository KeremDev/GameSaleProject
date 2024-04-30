using GameSaleProject.Concretes;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject
{
    public class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();    
            SaleManager saleManager = new SaleManager();    

            //Oyuncuları Tanımlama
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Kerem";
            gamer1.LastName = "Nazario";  
            gamer1.DateOfBirth = 1988;
            gamer1.IdentityNo = "22222222222";

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.FirstName = "Zeliha";
            gamer2.LastName = "Nazario";
            gamer2.DateOfBirth = 1987;
            gamer2.IdentityNo = "11111111111";

            //Oyun Tanımlama
            Game game1=new Game();
            game1.Id = 1;
            game1.GameName = "FİFA24";
            game1.GamePrice = 2000;

            Game game2 = new Game();
            game2.Id = 2;
            game2.GameName = "GTA 5";
            game2.GamePrice = 1400;

            //Kampanya Tanımlama
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.campaignName = "Black Friday";
            campaign1.DiscountAmount = 40;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 2;
            campaign2.campaignName = "Summer Discount";
            campaign2.DiscountAmount = 25;


            Console.WriteLine("-------------------OYUNCULAR LİSTESİ---------------------");
            Gamer[] gamers = new Gamer[] { gamer1, gamer2 };

            foreach (var gamer in gamers)
            {
                Console.WriteLine($"ID: {gamer.Id}, Name: {gamer.FirstName}, Surname: {gamer.LastName}, BirthYear: {gamer.DateOfBirth}");
            }

            Console.WriteLine("-------------------OYUN LİSTESİ---------------------");
            Game[] games = new Game[] { game1, game2 };

            foreach (var game in games)
            {
                Console.WriteLine($"ID: {game.Id}, Name: {game.GameName}, Fiyat: {game.GamePrice}");
            }

            Console.WriteLine("-------------------KAMPANYALAR LİSTESİ---------------------");
            Campaign[] campaigns = new Campaign[] {campaign1,campaign2};

            foreach (var campaign in campaigns)
            {
                Console.WriteLine($"ID: {campaign.CampaignId}, Name: {campaign.campaignName}, İndirim Yüzdesi: {campaign.DiscountAmount}");
            }

            Console.WriteLine("-------------------İŞLEMLER---------------------");
            gamerManager.Add(gamer1); // Oyuncu Ekleme Metodu Çalıştırma.
            gamerManager.Add(gamer2);
            gamerManager.Update(gamer2);
            gameManager.Add(game1); //Oyun Ekleme Metodu Çalıştırma.
            gameManager.Update(game2);
            campaignManager.Add(campaign1); //Kampanya Ekleme Çalıştırma
            campaignManager.Update(campaign1); // Kampanya GÜncelleme Çalıştırma
            saleManager.Sale(gamer1, game1); //Satış işleminin çalıştırılması.
            saleManager.SaleWithCampaign(gamer1,game1,campaign1); //Kampanyalı Satış İşlemi
            saleManager.SaleWithCampaign(gamer2, game2, campaign2);
           
            




            Console.ReadLine();
        }
    }
}
