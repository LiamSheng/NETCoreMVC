using Microsoft.AspNetCore.Mvc;

namespace NETCoreMVC.Controllers;

public class CategoryController : Controller
{
    // GET
    public IActionResult Index() // http://localhost:5287/Category/index
    {
        return View();
    }
}