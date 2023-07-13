using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class PizzaModel
    {

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int DB { get; set; }
        public string Type { get; set; }
        public string Sauce { get; set; }
        public int Pepperoni { get; set; }
        public int Ham { get; set; }
        public int Bacon { get; set; }
        public int Chicken { get; set; }
        public int MincedMeat { get; set; }
        public int Tomato { get; set; }
        public int Pepper { get; set; }
        public int Corn { get; set; }
        public int Mushroom { get; set; }
        public int Pineapple { get; set; }
        public int Ruccola { get; set; }
        public int EggDB { get; set; }
        public int ExtraCheese { get; set; }
    }
}
