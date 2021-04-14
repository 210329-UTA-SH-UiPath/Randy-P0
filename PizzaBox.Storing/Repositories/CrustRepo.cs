using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;
using System.Linq;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{

    public class Sizerepository : IRepository<Size>
    {
        public void Add(Crust genericType)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<Size> GetList()
        {
            PizzaboxDBContext Context = new PizzaboxDBContext();
            CrustMapper Mapper = new CrustMapper();

            return Context.PizzaSizes.Selecht(Mapper.Map).ToList();

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