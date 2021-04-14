using AutoMapper;
using PizzaBox.Domain.Model;
using PizzaBox.Storing.Entities;

namespace PizzaBox.Storing.Mappers
{
    public class StoreMapper
    {
        public Store Map(PizzaStore store)
        {
            return new Store
            {
                Id = store.Id,
                Stores = store.Stores,
                Orders = store.Orders
            };
        }

        public PizzaStore Map(Store store)
        {
            return new PizzaStore
            {
                Id = store.Id,
                Stores = store.Stores,
                Orders = store.Orders
            };
        }
    }
}