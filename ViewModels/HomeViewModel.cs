using PersonalWebsite.Models;

namespace PersonalWebsite.ViewModels;

public class HomeViewModel
{
    public AboutMe? About { get; set; }
    public List<Project> Projects { get; set; } = new();
}
