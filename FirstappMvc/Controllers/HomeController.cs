using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstappMvc.Models;

namespace FirstappMvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
