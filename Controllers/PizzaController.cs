using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }
    // GET all (recupera todas Pizzas)
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

    // GET (recupera Pizza por Id)
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if (pizza == null)
        {
            return NotFound();
        }
        return pizza;
    }

    // POST (cria num novo objeto Pizza)
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);
    }

    // [HttpPost("{id}")]
    // public IActionResult Update(int id, Pizza pizza)
    // {
    // }

    // [HttpDelete("{id}")]
    // public IActionResult Delete(int id)
    // {
    // }
}
