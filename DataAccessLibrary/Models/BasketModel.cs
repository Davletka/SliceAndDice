﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class BasketModel
    {
        public int ID_Basket { get; set; }
        public int User_id { get; set; }
        public int Dish_id { get; set; }
        public int Count { get; set; }
    }
}
