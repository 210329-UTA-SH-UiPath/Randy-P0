using AutoMapper;
using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;

namespace PizzaBox.Storing.Mappers
{
    public class OrderMapper
    {

        public Order Map(PizzaOrder order)
        {
            return new Order
            {
                Id = order.Id,
                Store = order.Store,
                Pizzas = order.Pizzas,
                Totalprice = order.Totalprice,
                Customer = order.Customer
            };
        }

        public PizzaOrder Map(Order order)
        {
            return new PizzaOrder
            {
                Id = order.Id,
                Store = order.Store,
                Pizzas = order.Pizzas,
                Totalprice = order.Totalprice,
                Customer = order.Customer
            };
        }
    }
}

