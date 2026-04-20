using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Data;
using PersonalWebsite.ViewModels;

namespace PersonalWebsite.Controllers;

public class CvController : Controller
{
    private readonly AppDbContext _db;

    public CvController(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IActionResult> Index()
    {
        var vm = new CvViewModel
        {
            Experiences = await _db.Experiences.OrderByDescending(e => e.StartDate).ToListAsync(),
            Educations = await _db.Educations.OrderByDescending(e => e.StartYear).ToListAsync(),
            ItExperience = await _db.ItExperience.ToListAsync()
        };
        return View(vm);
    }
}
