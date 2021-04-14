using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;
using System.Linq;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{

    public class Storerepository : IRepository<Store>
    {
        public void Add(Store genericType)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<Store> GetList()
        {
            PizzaboxDBContext Context = new PizzaboxDBContext();
            StoreMapper Mapper = new StoreMapper();

            return Context.PizzaStores.Select(Mapper.Map).ToList();

        }
        public void Remove(Store genericType)
        {
            throw new System.NotImplementedException();
        }

        public void update(Store existingType, Store updatedType)
        {
            throw new System.NotImplementedException();
        }
    }


}