using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABCRestaurant.Data.Entitys
{
    public class IEntity
    {
        [Key]
        public int ID { get; set; }
    }
}
