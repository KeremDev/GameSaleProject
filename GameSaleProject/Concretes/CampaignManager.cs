using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concretes
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Tebrikler " + campaign.campaignName + " Kampanyası Eklendi !");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Tebrikler " + campaign.campaignName + " Kampanyası Silindi !");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Tebrikler " + campaign.campaignName + " Kampanyası Güncellendi !");
        }
    }
}
