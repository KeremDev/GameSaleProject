﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Entities
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string campaignName { get; set; }
        public decimal DiscountAmount { get; set;}
    }
}
