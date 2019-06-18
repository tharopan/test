using ABCRestaurant.Data.DBConn;
using ABCRestaurant.Data.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Repository
{
    public class MenuRepository 
        : Repository<Menu>,IMenuRepository
    {
        public MenuRepository(RestaurantDBContext dBConn) 
            : base(dBConn)
        {

        }
    }
}
