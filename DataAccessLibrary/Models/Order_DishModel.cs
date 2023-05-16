using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class Order_DishModel
    {
        public int ID_Order_Dish { get; set; }
        public int Order_id { get; set; }
        public int Dish_id { get; set; }
        public int Count { get; set; }
    }
}
