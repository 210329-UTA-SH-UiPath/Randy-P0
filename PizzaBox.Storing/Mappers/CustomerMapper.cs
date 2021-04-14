using AutoMapper;
using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;

namespace PizzaBox.Storing.Mappers
{
    public class CustomerMapper
    {
        public ACustomer Map(Customer customer)
        {
            return new ACustomer
            {
                Id = customer.Id,
                CustomerName = customer.CustomerName,

            };
        }

        public Customer Map(ACustomer customer)
        {
            return new Customer
            {
                Id = customer.Id,
                CustomerName = customer.CustomerName,
            };
        }
    }
}