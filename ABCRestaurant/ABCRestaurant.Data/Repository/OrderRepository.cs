using ABCRestaurant.Data.DBConn;
using ABCRestaurant.Data.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Repository
{
    public class OrderRepository 
        : Repository<Order> , IOrderRepository
    {
        public OrderRepository(RestaurantDBContext dBConn) 
            : base(dBConn)
        {

        }
    }
}
