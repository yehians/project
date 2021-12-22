using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Iitem
    {
        public int id { get; set; }
        public string name_Item { get; set; }
        public int price { get; set; }
        public bool Is_aviliblity { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int age_limitiation { get; set; }
        public bool Dish_of_the_day { get; set; }
        public int Amount { get; set; }
    }
}