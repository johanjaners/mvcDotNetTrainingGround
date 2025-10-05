using Microsoft.AspNetCore.Mvc;
using mvcDotNetTrainingGround.Models; // Db
namespace mvcDotNetTrainingGround.Controllers;
public class DeveloperControllers : Controller
{
    private Db _db;
    public DeveloperControllers(Db db)
    {
        _db = db;
    }
    public IActionResult Index() => View(_db.Developers);
}