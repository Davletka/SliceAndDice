using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IDatabseData
    {
        Task DelteBasket(BasketModel item);
        Task DelteEmployee(EmployeeModel item);
        Task<List<BasketModel>> GetBasket();
        Task<List<DishModel>> GetDish();
        Task<List<EmployeeModel>> GetEmployee();
        Task<List<OrderModel>> GetOrder();
        Task<List<Order_DishModel>> GetOrderDish();
        Task<List<RoleModel>> GetRole();
        Task<List<StatusModel>> GetStatus();
        Task<List<UserModel>> GetUser();
        Task InsertBasket(BasketModel user);
        Task InsertDish(DishModel user);
        Task InsertEmployee(EmployeeModel user);
        Task InsertOrder(OrderModel user);
        Task InsertOrderDish(Order_DishModel user);
        Task InsertUser(UserModel user);
        Task UpdateBasket(BasketModel item);
        Task UpdateUser(UserModel item);
    }
}