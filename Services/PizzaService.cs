using ContosoPizza.Models;

namespace ContosoPizza.Services
{
    public static class PizzaService
    {
        static List<Pizza> Pizzas { get; }
        static int nextId = 3;
        static PizzaService()
        {
            Pizzas = new List<Pizza>
            {
                new Pizza { Id = 1, Name = "Três queijos", IsGlutenFree = false},
                new Pizza { Id = 2, Name = "Portuguesa", IsGlutenFree = true}
            };
        }
        public static List<Pizza> GetAll() => Pizzas;

        public static Pizza? Get(int Id) => Pizzas.FirstOrDefault(p => p.Id == Id);

        // Unidade 5
    }
}
