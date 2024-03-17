namespace Model;

public class RefreshSession
{
    public string Token { get; set; }
    public string ExpiresIn { get; set; } // TODO: change name in spec
    public string Fingerprint { get; set; }
    public User User { get; set; }
}