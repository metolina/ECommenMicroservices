using FreeCourse.Shared.Dtos;
using FreeCourse.Sservices.Basket.Dtos;
using System.Threading.Tasks;

namespace FreeCourse.Sservices.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userId);
        Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);
        Task<Response<bool>> Delete(string userId);
    }
}
