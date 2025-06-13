using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyProject.MVC.Models;

namespace MyProject.MVC.Controllers;

public class AracController : Controller
{
    private readonly ILogger<AracController> _logger;

    public AracController(ILogger<AracController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
