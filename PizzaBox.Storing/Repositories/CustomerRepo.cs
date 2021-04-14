using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;
using System.Linq;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{

    public class Customerrepository : IRepository<ACustomer>
    {
        public void Add(ACustomer genericType)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<ACustomer> GetList()
        {
            PizzaboxDBContext Context = new PizzaboxDBContext();
            CustomerMapper Mapper = new CustomerMapper();

            return Context.Customers.Select(Mapper.Map).ToList();

        }

        public void Remove(ACustomer genericType)
        {
            throw new System.NotImplementedException();
        }

        public void update(ACustomer existingType, ACustomer updatedType)
        {
            throw new System.NotImplementedException();
        }
    }


}