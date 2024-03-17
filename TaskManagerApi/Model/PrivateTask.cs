namespace Model;

public class PrivateTask
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
    public DateTime Deadline { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; } // TODO: add to spec
    public PrivateBoard Board { get; set; }
    public PrivateCategory Category { get; set; }
    public User User { get; set; }
}