using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using query1.Models;

namespace query1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly StudentDbContext _context;
    public HomeController(ILogger<HomeController> logger, StudentDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View(model: _context._Students.ToList());
    }

    public IActionResult Add(Student s)
    {
        _context._Students.Add(s);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult Register()
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