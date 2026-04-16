using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite.Models;

public class ContactMessage
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Namn är obligatoriskt")]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "E-post är obligatorisk")]
    [EmailAddress(ErrorMessage = "Ange en giltig e-postadress")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ämne är obligatoriskt")]
    [StringLength(200)]
    public string Subject { get; set; } = string.Empty;

    [Required(ErrorMessage = "Meddelande är obligatoriskt")]
    [StringLength(2000)]
    public string Message { get; set; } = string.Empty;

    public DateTime SentAt { get; set; } = DateTime.UtcNow;
}
