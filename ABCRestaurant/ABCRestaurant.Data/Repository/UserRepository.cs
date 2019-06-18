using ABCRestaurant.Data.DBConn;
using ABCRestaurant.Data.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABCRestaurant.Data.Repository
{
    public class UserRepository 
        : Repository<User> ,IUserRepository
    {
        public UserRepository(RestaurantDBContext dBConn) 
            : base(dBConn)
        {

        }
    }
}
