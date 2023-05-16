using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class OrderModel
    {
        public int ID_Order { get; set; }
        public int User_id { get; set; }
        public int? Employee_id { get; set; }
        public int Status_id { get; set; }
        public int Sum { get; set; }
    }
}
