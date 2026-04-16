using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Data;
using PersonalWebsite.Models;

namespace PersonalWebsite.Controllers;

public class ContactController : Controller
{
    private readonly AppDbContext _db;

    public ContactController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new ContactMessage());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ContactMessage model)
    {
        if (!ModelState.IsValid)
            return View(model);

        model.SentAt = DateTime.UtcNow;
        _db.ContactMessages.Add(model);
        await _db.SaveChangesAsync();
        return RedirectToAction(nameof(Success));
    }

    public IActionResult Success()
    {
        return View();
    }
}
