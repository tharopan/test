using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Entitys
{
    public class Menu : IEntity
    {
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
        public int Unit { get; set; }
        public double Price { get; set; }
    }
}
