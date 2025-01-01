using Microsoft.AspNetCore.Mvc;

namespace ApiCatalogo.Controllers;

public class CategoriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}