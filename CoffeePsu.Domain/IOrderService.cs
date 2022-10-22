using CoffeePsu.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePsu.Domain.Contracts
{
    public interface IOrderService
    {
        OrderModel CreateOrder(OrderModel order);
    }
}
