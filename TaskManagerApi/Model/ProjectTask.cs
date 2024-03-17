namespace Model;

public class ProjectTask
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
    public DateTime Deadline { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; } // TODO: add to spec
    public ProjectBoard Board { get; set; }
    public ProjectCategory Category { get; set; }
    public Project Project { get; set; }
}