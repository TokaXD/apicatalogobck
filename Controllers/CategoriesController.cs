using ApiCatalogo.Context;
using ApiCatalogo.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatalogo.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ApiCatalogoContext _context;

    public CategoriesController(ApiCatalogoContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Category>> Get()
    {
        return _context.Categories.ToList();
    }

    [HttpGet("{id:int}", Name = "GetCategories")]
    public ActionResult<Category> Get(int id)
    {
        var category = _context.Categories.FirstOrDefault(c => c.Id == id);
        if (category == null)
        {
            return NotFound("Categoria não encontrada");
        }

        return Ok(category);
    }

    [HttpPost]
    public ActionResult<Category> Post(Category category)
    {
        if (category is null)
        {
            return BadRequest();
        }

        _context.Categories.Add(category);
        _context.SaveChanges();

        return new CreatedAtRouteResult("GetCategories", new { id = category.Id }, category);
    }
}