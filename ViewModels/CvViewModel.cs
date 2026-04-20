using PersonalWebsite.Models;

namespace PersonalWebsite.ViewModels;

public class CvViewModel
{
    public List<Experience> Experiences { get; set; } = new();
    public List<Education> Educations { get; set; } = new();
    public List<ITExperience> ItExperience { get; set; } = new();
}
