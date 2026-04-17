namespace PersonalWebsite.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? Grade { get; set; }
    public DateTime? StartDate { get; set; }
    public int EducationId { get; set; }
    public Education Education { get; set; } = null!;
}
