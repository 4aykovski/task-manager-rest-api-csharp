namespace Model;

public class PrivateCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public PrivateBoard Board { get; set; }
    public ICollection<PrivateTask> Tasks { get; set; }
}