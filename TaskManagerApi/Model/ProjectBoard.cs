namespace Model;

public class ProjectBoard
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public Project Project { get; set; }
    public ICollection<ProjectCategory> Categories { get; set; }
}