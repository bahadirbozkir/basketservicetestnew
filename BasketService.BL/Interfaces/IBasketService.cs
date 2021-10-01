using BasketService.BL.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.BL.Interfaces
{
    public interface IBasketService
    {
        Task<BasketResponse> CheckBasketByBasketIdAsync(long basketId);
    }
}
