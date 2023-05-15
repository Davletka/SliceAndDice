using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class DishModel
    {
        public int ID_DIsh { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public byte InMenu { get; set; }
        public byte[]? Image { get; set; }
    }
}
