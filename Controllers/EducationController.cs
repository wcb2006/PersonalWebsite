using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Data;

namespace PersonalWebsite.Controllers;

public class EducationController : Controller
{
    private readonly AppDbContext _db;

    public EducationController(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        var educations = await _db.Educations.Include(e => e.Courses).OrderByDescending(e => e.StartYear).ToListAsync();
        return View(educations);
    }
}
