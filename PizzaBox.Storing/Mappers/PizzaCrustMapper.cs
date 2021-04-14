using AutoMapper;
using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;

namespace PizzaBox.Storing.Mappers
{
    public class CrustMapper
    {
        public Crust Map(PizzaCrust crust)
        {
            return new Crust
            {
                Id = crust.Id,
                crust = crust.Crust,
                Price = crust.Price
            };
        }

        public PizzaCrust Map(Crust crust)
        {
            return new PizzaCrust
            {
                Id = crust.Id,
                Crust = crust.crust,
                Price = crust.Price
            };
        }
    }
}