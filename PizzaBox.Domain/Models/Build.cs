namespace PizzaBox.Domain.Model
{
    public partial class Build
    {
        public int Id { get; set; }

        public string PizzaType { get; set; }

        public string Crust { get; set; }

        public string Size { get; set; }
        public string Toppings { get; set; }

        public decimal? Price { get; set; }
    }
}
