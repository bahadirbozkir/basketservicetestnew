using BasketService.BL.Requests;
using BasketService.BL.Responses;
using BasketService.BL.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.BL.Interfaces
{
    public interface IBasketItemService
    {
        Task AddBasketItemAsync(BasketItemRequest basketItemRequest);
    }
}
