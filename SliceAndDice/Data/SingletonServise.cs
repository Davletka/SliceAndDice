using DataAccessLibrary.Models;

namespace SliceAndDice.Data
{
    public class SingletonServise
    {
        UserModel user = null;

        public UserModel GetUser()
        {

            return user;
        }
        public void SetUser(UserModel newUser)
        {
            user = newUser;
        }
    }
}
