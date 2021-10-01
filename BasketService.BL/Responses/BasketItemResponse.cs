using System;
using System.Collections.Generic;
using System.Text;

namespace BasketService.BL.Responses
{
    public class BasketItemResponse
    {
        public BasketItemResponse()
        {   
            AppliedCampaigns = new List<AppliedCampaignResponse>();
        }

        public long Id { get; set; }
        public long BasketId { get; set; }
        public long ProductVariantId { get; set; }
        public long ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }

        public decimal AffectedTotal { get; set; }

        public List<AppliedCampaignResponse> AppliedCampaigns { get; set; }
    }
}
