using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Entitys
{
    public class Order :IEntity
    {
        public string OrderDate { get; set; }
        public virtual Menu MenuItem { get; set; }
        public virtual User LoginUser { get; set; }
    }
}
