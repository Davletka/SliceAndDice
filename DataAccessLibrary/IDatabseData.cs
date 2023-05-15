using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IDatabseData
    {
        Task DelteBasket(BasketModel item);
        Task<List<BasketModel>> GetBasket();
        Task<List<DishModel>> GetDish();
        Task<List<OrderModel>> GetOrder();
        Task<List<UserModel>> GetUser();
        Task InsertBasket(BasketModel user);
        Task InsertDish(DishModel user);
        Task InsertOrder(OrderModel user);
        Task InsertUser(UserModel user);
        Task UpdateBasket(BasketModel item);
        Task UpdateUser(UserModel item);
    }
}