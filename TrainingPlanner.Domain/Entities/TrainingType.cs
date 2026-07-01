namespace TrainingPlanner.Domain.Entities;

public class TrainingType
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }

    // Navigation properties
    public ICollection<TrainingPlan> TrainingPlans { get; set; } = new List<TrainingPlan>();
}
