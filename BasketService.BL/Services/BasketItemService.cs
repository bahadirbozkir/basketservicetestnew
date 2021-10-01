using AutoMapper;
using BasketService.BL.Interfaces;
using BasketService.BL.Requests;
using BasketService.BL.Responses;
using BasketService.DAL.Entity;
using BasketService.DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.BL.Services
{
    public class BasketItemService : IBasketItemService
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion

        #region Ctor

        public BasketItemService(IUnitOfWork unitOfWork,
                                 IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion
        public async Task AddBasketItemAsync(BasketItemRequest basketItemRequest)
        {
            var basketItemRepository = _unitOfWork.GetRepository<BasketItem>();

            var basketItem = basketItemRepository.FindBy(x => x.BasketId == basketItemRequest.BasketId && x.ProductId == basketItemRequest.ProductId).FirstOrDefault();

            if (basketItem == null)
            {
                basketItem = new BasketItem()
                {
                    BasketId = basketItemRequest.BasketId,
                    ProductId = basketItemRequest.ProductId,
                    Quantity = 1
                };

                await basketItemRepository.AddAsync(basketItem);
            }
            else
            {
                if (basketItemRequest.AddOrRemove == Enums.AddOrRemove.Add)
                {
                    basketItem.Quantity += 1;
                }
                else
                {
                    basketItem.Quantity -= 1;
                }

                if (basketItem.Quantity < 1)
                {
                    await basketItemRepository.DeleteAsync(basketItem);
                }
                else
                {
                    await basketItemRepository.UpdateAsync(basketItem);
                }
            }

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
