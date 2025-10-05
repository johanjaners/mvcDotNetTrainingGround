using Microsoft.AspNetCore.Mvc;
using mvcDotNetTrainingGround.Models; // Db
namespace mvcDotNetTrainingGround.Controllers;

[Route("[controller]")]
public class DevelopersController : Controller
{
    private Db _db;
    public DevelopersController(Db db)
    {
        _db = db;
    }
    [HttpGet("")]
    [HttpGet("Index")]
    public IActionResult Index() => View(_db.Developers);
}