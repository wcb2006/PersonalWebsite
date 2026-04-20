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

    public async Task<IActionResult> Index(string? category)
    {
        var query = _db.Projects.AsQueryable();

        if (!string.IsNullOrEmpty(category))
        {
            query = query.Where(p => p.Category == category);
        }

        var projects = await query.OrderByDescending(p => p.Year).ToListAsync();

        ViewData["Category"] = category;
        return View(projects);
    }
}
