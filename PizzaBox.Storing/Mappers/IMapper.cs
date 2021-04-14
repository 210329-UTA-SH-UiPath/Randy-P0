namespace PizzaBox.Storing.Mappers
{

    public interface IMapper<Entities, Domain>
    {

        Domain Map(Entities database);

        Entities Map(Domain model);

    }
}

