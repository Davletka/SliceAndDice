﻿using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class DatabseData : IDatabseData
    {
        private readonly ISqlDataAccess _db;

        public DatabseData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<UserModel>> GetUser()
        {
            string sql = "select * from dbo.Users";

            return _db.LoadData<UserModel, dynamic>(sql, new { });
        }

        public Task InsertUser(UserModel user)
        {
            string sql = @"insert into dbo.Users(Login, Password, FName, LName, Address, PhoneNumber, Employee_id)
                values (@Login, @Password, @FName, @LName, @Address, @PhoneNumber, @Employee_id);";
            return _db.SaveData(sql, user);

        }
        public Task UpdateUser(UserModel item)
        {
            var sql = "UPDATE Users SET Login = @Login, FName = @FName, LName = @LName, Address = @Address, PhoneNumber = @PhoneNumber, Employee_id = @Employee_id WHERE ID_User = @ID_User";
            return _db.SaveData(sql, item);

        }
        public Task<List<DishModel>> GetDish()
        {
            string sql = "select * from dbo.Dish";

            return _db.LoadData<DishModel, dynamic>(sql, new { });
        }

        public Task InsertDish(DishModel user)
        {
            string sql = @"insert into dbo.Dish(Name, Description, Cost, Image, InMenu)
                values (@Name, @Description, @Cost, @Image, @InMenu);";
            return _db.SaveData(sql, user);
        }
        public Task<List<BasketModel>> GetBasket()
        {
            string sql = "select * from dbo.Basket";

            return _db.LoadData<BasketModel, dynamic>(sql, new { });
        }

        public Task InsertBasket(BasketModel user)
        {
            string sql = @"insert into dbo.Basket(User_id, Dish_id, Count)
                values (@User_id, @Dish_id, @Count);";
            return _db.SaveData(sql, user);
        }
        public Task UpdateBasket(BasketModel item)
        {
            var sql = "UPDATE Basket SET User_id = @User_id, Dish_id = @Dish_id, Count = @Count WHERE ID_Basket = @ID_Basket";
            return _db.SaveData(sql, item);

        }
        public Task DelteBasket(BasketModel item)
        {
            var sql = "DELETE FROM Basket WHERE ID_Basket = @ID_Basket";
            return _db.SaveData(sql, item);

        }
        public Task<List<OrderModel>> GetOrder()
        {
            string sql = "select * from dbo.Order";

            return _db.LoadData<OrderModel, dynamic>(sql, new { });
        }

        public Task InsertOrder(OrderModel user)
        {
            string sql = @"insert into dbo.Order(User_id, Employee_id, Status_id, Sum)
                values (@User_id, @Employee_id, @Status_id, @Sum);";
            return _db.SaveData(sql, user);
        }
    }
}
