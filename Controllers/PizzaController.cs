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
    // GET
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();
}
