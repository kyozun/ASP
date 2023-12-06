using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers;

public class DepartmentController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}