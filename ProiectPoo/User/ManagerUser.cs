
using System.Diagnostics.Metrics;
using System.Text.Json;

public class ManagerUser
{
    private List<User> userList = new List<User>();
    private int userIdCounter;

    public ManagerUser()
    {
        LoadUserFromJson();
        userIdCounter = updateUserIdCounter();
    }
    private int updateUserIdCounter()
    {
        if (userList.Count == 0)
            return 0;
        var temp=userList.Count;
        return userList[temp - 1].ID + 1;
    }

    public void Register(string userName, string password)
    {
        User newUser = new User(userIdCounter++, userName, password);
        userList.Add(newUser);
    }
    public bool Login(string userName, string password)
    {
        foreach (var user in userList)
        {
            if (user.UserName == userName && user.Password == password)
            {
                return true;
            }
        }
        return false;
    }

    public void AddAccount(string userName, string password)
    {
        User newUser = new User(userIdCounter++, userName, password);
        userList.Add(newUser);
    }

    public void DeleteAccount(int userId)
    {
        var user = userList.Find(u => u.ID == userId);
        if (user != null)
        { 
            userList.Remove(user);
        }
    }

    public void ModifyAccount(int userId, string newUserName, string newPassword)
    {
        var user = uerList.Find(u => u.ID == userId);
        if (user != null)
        {
            user.UserName = newUserName;
            user.Password = newPassword;
        }
    }

    public bool UserExsist(string username)
    {
        foreach(var user in userList)
        {
            if (user.UserName == username)
                return true;
        }
        return false;
    }

    public void LoadUsersFromJson()
    {
        string jsonString = File.ReadAllText("users.json");
        userList = JsonSerializer.Deserialize<userList<User>>(jsonString);
    }
    public void SaveDataToJson()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        strong jsonString = JsonSerializer(userList, options);
        File.WriteAllText("users.json", jsonString);
    }

    public UserGetAccount(string user)
    {
        return userList.Find(u => u.UserName == user);
    }
}