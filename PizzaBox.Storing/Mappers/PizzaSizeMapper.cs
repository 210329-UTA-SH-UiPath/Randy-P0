using AutoMapper;
using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;

namespace PizzaBox.Storing.Mappers
{
    public class SizeMapper
    {
        public Size Map(PizzaSize size)
        {
            return new Size
            {
                Id = size.Id,
                size = size.Size,
                Price = size.Price
                //  PizzaToppings = topping.PizzaToppings.Select(x => Map(x)).ToList()
            };
        }

        public PizzaSize Map(Size size)
        {
            return new PizzaSize
            {
                Id = size.Id,
                Size = size.size,
                Price = size.Price
            };
        }
    }
}