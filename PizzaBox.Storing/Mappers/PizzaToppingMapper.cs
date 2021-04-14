using AutoMapper;
using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;

namespace PizzaBox.Storing.Mappers
{
    public class TopppingMapper
    {
        public Topping Map(PizzaTopping topping)
        {
            return new Topping
            {
                Id = topping.Id,
                Toppings = topping.Toppings,
                Price = topping.Price
                //  PizzaToppings = topping.PizzaToppings.Select(x => Map(x)).ToList()
            };
        }

        public PizzaTopping Map(Topping topping)
        {
            return new PizzaTopping
            {
                Id = topping.Id,
                Toppings = topping.Toppings,
                Price = topping.Price
            };
        }
    }

}