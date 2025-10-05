using Microsoft.AspNetCore.Mvc;
using mvcDotNetTrainingGround.Models; // Db
namespace mvcDotNetTrainingGround.Controllers;

public class DevelopersController : Controller
{
    private Db _db;
    public DevelopersController(Db db)
    {
        _db = db;
    }
    public IActionResult Index() => View(_db.Developers);

    public IActionResult Details(int id)
    {
        var developer = _db.Developers.Find(d => d.Id == id);
        if (developer == null) return NotFound();
        return View(developer);
    }
    public IActionResult Create() => View();
    [HttpPost]
    public IActionResult Create(CreateNewDeveloperViewModel viewModel)
    {
        var nextId = _db.Developers.Count + 1;
        var developerToAdd = new Developer()
        {
            Id = nextId,
            Name = viewModel.Name,
            Email = viewModel.Email
        };
        _db.Developers.Add(developerToAdd);
        
        return RedirectToAction(nameof(Index));
    }
}