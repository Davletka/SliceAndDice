using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class UserModel
    {
        public int ID_User { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int? Employee_id { get; set; }
    }
}
