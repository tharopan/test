using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABCRestaurant.Data.Entitys;
using ABCRestaurant.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ABCRestaurent.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(OrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        [HttpGet]
        public List<Order> GetAllOrders()
        {
            List<Order> _List = this._orderRepository.List().ToList();
            return _List;
        }
        [HttpPost]
        public void InsertOrder(Order order)
        {
            this._orderRepository.Add(order);
        }
    }
}