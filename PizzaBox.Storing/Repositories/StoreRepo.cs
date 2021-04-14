using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;
using System.Linq;
using PizzaBox.Storing.Mappers;

namespace PizzaBox.Storing.Repositories
{

    public class Sizerepository : IRepository<Size>
    {
        public void Add(Size genericType)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<Size> GetList()
        {
            PizzaboxDBContext Context = new PizzaboxDBContext();
            SizeMapper Mapper = new SizeMapper();

            return Context.PizzaSizes.Select(Mapper.Map).ToList();

        }

        public void Remove(Size genericType)
        {
            throw new System.NotImplementedException();
        }

        public void update(Size existingType, Size updatedType)
        {
            throw new System.NotImplementedException();
        }
    }


}