using System;
using System.Collections.Generic;
using System.Text;

namespace BasketService.BL.Responses
{
    public class AppliedCampaignResponse
    {
        public long CampaignId { get; set; }

        public string Name { get; set; }

        public int Priority { get; set; }

        public decimal DiscountAmount { get; set; }

        public DiscountType DiscountType { get; set; }

        public AmountType AmountType { get; set; }

        public string DiscountTypeName { get; set; }
    }
}
