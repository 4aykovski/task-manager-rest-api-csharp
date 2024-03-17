namespace Model;

public class User
{
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public DateTime RegisteredAt { get; set; } // TODO: change name in spec
    public DateTime LastLoginAt { get; set; } // TODO: change name in spec
    public bool IsAdmin { get; set; } // TODO: change name in spec
    public string About { get; set; }
    public string Language { get; set; }
    public string Theme { get; set; }
    public ICollection<RefreshSession> RefreshSessions { get; set; }
    public ICollection<Task> Tasks { get; set; }
    public ICollection<PrivateBoard> Boards { get; set; }
    public ICollection<ProjectMember> ProjectsMember { get; set; }
    public ICollection<Project> ProjectsOwner { get; set; }
}