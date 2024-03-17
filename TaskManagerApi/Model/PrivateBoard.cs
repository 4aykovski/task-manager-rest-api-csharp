namespace Model;

public class PrivateBoard
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public User User { get; set; }
    public ICollection<PrivateCategory> Categories { get; set; }
}