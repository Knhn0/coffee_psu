using CoffeePsu.Domain.Contracts;
using CoffeePsu.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePsu.Domain.Implemntations.Services
{
    public class OrderService : IOrderService
    {
        public OrderModel? CreateOrder(OrderModel order)
        {
            if(order.Id == 0)
            {
                return null;
            }
            if (string.IsNullOrEmpty(order.Name))
            {
                return null;
            }
            if (order.Price <= 0)
            {
                return null;
            }
            return order;
        }
    }
}
