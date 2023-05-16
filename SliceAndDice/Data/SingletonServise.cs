using DataAccessLibrary.Models;

namespace SliceAndDice.Data
{
    public class SingletonServise
    {
        UserModel user = null;
        string role = "";

        public UserModel GetUser()
        {
            return user;
        }
        public void SetUser(UserModel newUser)
        {
            user = newUser;
        }       
        public string GetRole()
        {
            return role;
        }
        public void SetRole(string newRole)
        {
            role = newRole;
        }

    }
}
