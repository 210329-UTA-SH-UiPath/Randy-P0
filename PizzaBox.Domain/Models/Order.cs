namespace PizzaBox.Domain.Model
{
    public partial class Order
    {
        public decimal Id { get; set; }

        public string Store { get; set; }

        public string Pizzas { get; set; }

        public string Orders { get; set; }

        public decimal Totalprice { get; set; }
        public string Customer { get; set; }
    }
}
