namespace Model;

public class ProjectMember
{
    public Guid UserId { get; set; }
    public int ProjectId { get; set; }
    public User User { get; set; }
    public Project Project { get; set; }
}