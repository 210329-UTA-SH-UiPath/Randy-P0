using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;
using System.Linq;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{

    public class Toppingrepository : IRepository<Topping>
    {
        public void Add(Topping genericType)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<Topping> GetList()
        {
            PizzaboxDBContext Context = new PizzaboxDBContext();
            ToppingMapper Mapper = new ToppingMapper();

            return Context.PizzaToppings.Select(Mapper.Map).ToList();

        }

        public void Remove(Topping genericType)
        {
            throw new System.NotImplementedException();
        }

        public void update(Topping existingType, Topping updatedType)
        {
            throw new System.NotImplementedException();
        }
    }


}