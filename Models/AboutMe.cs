namespace PersonalWebsite.Models;

public class AboutMe
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;

    // Engelska varianter. Null = ingen översättning, då visas svenskan.
    public string? TitleEn { get; set; }
    public string? BioEn { get; set; }
    public string? ProfileImageUrl { get; set; }
    public string? GithubUrl { get; set; }
    public string? LinkedInUrl { get; set; }
}
