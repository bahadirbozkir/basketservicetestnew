using BasketService.BL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasketService.BL.Responses
{
    public class BasketResponse
    {
        public BasketResponse()
        {
            BasketItems = new List<BasketItemResponse>();
            AppliedCampaigns = new List<AppliedCampaignResponse>();
        }

        public long Id { get; set; }

        public long CustomerId { get; set; }

        public List<BasketItemResponse> BasketItems { get; set; }

        public List<AppliedCampaignResponse> AppliedCampaigns { get; set; }
    }
}
