using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;
using System.Linq;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{

    public class Orderrepository : IRepository<Order>
    {
        public void Add(Order genericType)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<Order> GetList()
        {
            PizzaboxDBContext Context = new PizzaboxDBContext();
            OrderMapper Mapper = new OrderMapper();

            return Context.PizzaOrders.Select(Mapper.Map).ToList();

        }

        public void Remove(Order genericType)
        {
            throw new System.NotImplementedException();
        }

        public void update(Order existingType, Order updatedType)
        {
            throw new System.NotImplementedException();
        }
    }


}