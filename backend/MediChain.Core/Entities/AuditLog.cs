namespace MediChain.Core.Entities;

public class AuditLog : BaseEntity
{
    public Guid UserId { get; set; }

    public User User { get; set; } = null!;

    public string Action { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string IPAddress { get; set; } = string.Empty;

    public DateTime ActionDate { get; set; } = DateTime.UtcNow;
}