using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Abstracts
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Remove(Campaign campaign);
        void Update(Campaign campaign);
    }
}
