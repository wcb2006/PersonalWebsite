namespace PersonalWebsite.Models;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
    public string? ProjectUrl { get; set; }
    public string? Technologies { get; set; }
    public int Year { get; set; }
    public string? Category { get; set; }
}
