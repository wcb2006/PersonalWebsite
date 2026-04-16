using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Data;

namespace PersonalWebsite.Controllers;

public class ProjectsController : Controller
{
    private readonly AppDbContext _db;

    public ProjectsController(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        var projects = await _db.Projects.OrderByDescending(p => p.Year).ToListAsync();
        return View(projects);
    }
}
