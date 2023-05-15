using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IUserData
    {
        Task<List<UserModel>> GetUser();
        Task InsertUser(UserModel user);
    }
}