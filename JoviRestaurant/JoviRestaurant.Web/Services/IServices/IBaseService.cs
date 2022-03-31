using JoviRestaurant.Web.Models;

namespace JoviRestaurant.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto ResponseModel{ get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
