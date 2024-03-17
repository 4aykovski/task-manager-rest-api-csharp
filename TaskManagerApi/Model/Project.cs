namespace Model;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; } // TODO: add to spec
    public User Owner { get; set; }
    public ICollection<ProjectMember> Members { get; set; }
}