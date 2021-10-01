using AutoMapper;
using BasketService.BL.Interfaces;
using BasketService.BL.Responses;
using BasketService.DAL.Entity;
using BasketService.DAL.UOW;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.BL.Services
{
    public class BasketService : IBasketService
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion

        #region Ctor
        public BasketService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion
        public async Task<BasketResponse> CheckBasketByBasketIdAsync(long basketId)
        {
            var basketRepo = _unitOfWork.GetRepository<Basket>();

            var basket = await basketRepo.GetAsync(basketId);

            return _mapper.Map<BasketResponse>(basket);
        }
    }
}
