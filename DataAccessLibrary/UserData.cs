﻿using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
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
    }
}
