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
    [HttpGet("{Id}")]
    public ActionResult<Pizza> Get(int Id)
    {
        var pizza = PizzaService.Get(Id);

        if (pizza == null)
        {
            return NotFound();
        }
        return pizza;
    }
}
