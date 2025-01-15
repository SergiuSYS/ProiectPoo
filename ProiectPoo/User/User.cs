 public class User
{
    public int ID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; } = false;

    public User(int id, string userName, string password)
    {
        ID = id;
        UserName = userName;
        Password = password;
        IsAdmin = isAdmin;
    }
}

