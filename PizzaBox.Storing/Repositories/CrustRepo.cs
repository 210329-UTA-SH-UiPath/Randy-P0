using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;
using System.Linq;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{

    public class Crustrepository : IRepository<Crust>
    {
        public void Add(Crust genericType)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<Crust> GetList()
        {
            PizzaboxDBContext Context = new PizzaboxDBContext();
            CrustMapper Mapper = new CrustMapper();

            return Context.PizzaCrusts.Select(Mapper.Map).ToList();
        }

        public void Remove(Crust genericType)
        {
            throw new System.NotImplementedException();
        }

        public void update(Crust existingType, Crust updatedType)
        {
            throw new System.NotImplementedException();
        }
    }


}