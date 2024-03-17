namespace Model;

public class ProjectCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public ProjectBoard Board { get; set; }
    public ICollection<ProjectTask> Tasks { get; set; }
}