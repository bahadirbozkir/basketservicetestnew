using BasketService.BL.Interfaces;
using BasketService.BL.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketItemController : ControllerBase
    {
        #region Fields
        private readonly IBasketItemService _basketItemService;
        private readonly IBasketService _basketService;

        #endregion

        #region Ctor

        public BasketItemController(IBasketItemService basketItemService,
                                    IBasketService basketService)
        {
            _basketItemService = basketItemService;
            _basketService = basketService;
        }

        [HttpPut("add")]
        public async Task<IActionResult> AddToBasket(BasketItemRequest addBasketItemRequest)
        {
            try
            {
                var checkBasket = await _basketService.CheckBasketByBasketIdAsync(addBasketItemRequest.BasketId);

                if (checkBasket == null)
                    return Ok("Basket does not exist");

                if (checkBasket.CustomerId != addBasketItemRequest.CustomerId)
                    return Ok("Basket does not belongs to customer");

                await _basketItemService.AddBasketItemAsync(addBasketItemRequest);

                return Ok("Added to basket");
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        #endregion
    }
}
