using ApiCatalogo.Context;
using ApiCatalogo.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogo.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ApiCatalogoContext _context;

    public ProductsController(ApiCatalogoContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> Get()
    {
        var products = _context.Products.ToList();

        if (products == null)
        {
            return NotFound("Produtos Não Encontrados");
        }

        return products;
    }

    [HttpGet("{id:int}", Name = "GetProduct")]
    public ActionResult<Product> Get(int id)
    {
        var product = _context.Products.FirstOrDefault(p => p.Id == id);

        if (product is null)
        {
            return NotFound("Produto Não Encontrado");
        }

        return product;
    }

    [HttpPost]
    public ActionResult Post(Product product)
    {
        if (product is null)
        {
            return BadRequest();
        }

        _context.Products.Add(product);

        _context.SaveChanges();

        return new CreatedAtRouteResult("GetProduct", new { id = product.Id }, product);
    }


    [HttpPut("{id:int}")]
    public ActionResult Put(int id, Product product)
    {
        if (id != product.Id)
        {
            return BadRequest("O id de alteração do body request deve ser o mesmo do path request!");
        }

        if (product is null)
        {
            return BadRequest("O Body do request não pode estar vazio!");
        }

        _context.Entry(product).State = EntityState.Modified;

        _context.SaveChanges();

        return Ok(product);
    }

    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        var product = _context.Products.FirstOrDefault(p => p.Id == id);

        if (product is null)
        {
            return NotFound("Produto não encontrado para deleção!");
        }

        _context.Products.Remove(product);
        _context.SaveChanges();

        return NoContent();
    }
}