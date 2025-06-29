using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyProject.MVC.Models;

namespace MyProject.MVC.Controllers;

public class ReactController : Controller
{
    private readonly ILogger<ReactController> _logger;

    public ReactController(ILogger<ReactController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
