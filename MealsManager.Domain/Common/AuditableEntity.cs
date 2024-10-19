namespace MealsManager.Domain.Common;

public class AuditableEntity
{
    public int Id { get; set; }

    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }

    public int StatusId { get; set; }
    public string? InavtivatedBy { get; set; }
    public DateTime? InactivatedOn { get; set; }
}
