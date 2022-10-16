using ContosoPizza.Models;

namespace ContosoPizza.Services
{
    public static class PizzaService
    {
        // Criando lista de Pizzas
        static List<Pizza> Pizzas { get; }
        static int nextId = 3;
        static PizzaService()
        {
            // Adicionando pizzas à lista
            Pizzas = new List<Pizza>
            {
                new Pizza {Id = 1, Name = "Três queijos", IsGlutenFree = false},
                new Pizza {Id = 2, Name = "Portuguesa", IsGlutenFree = true}
            };
        }
        // Método que retorna todas pizzas armazenadas
        public static List<Pizza> GetAll() => Pizzas;

        // Método que recupera pizza armazenada
        public static Pizza? Get(int Id) => Pizzas.FirstOrDefault(p => p.Id == Id);

        // Método que adiciona Pizza à lista de Pizzas
        public static void Add(Pizza pizza)
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }

        // Método que deleta Pizza da lista
        public static void Delete(int id)
        {
            var pizza = Get(id);

            if (pizza is null)
            {
                return;
            }
            Pizzas.Remove(pizza);
        }

        // Método que atualiza alguma pizza conforme seu Id
        public static void Update(Pizza pizza)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);

            if (index == -1)
            {
                return;
            }

            Pizzas[index] = pizza;
        }
    }
}
