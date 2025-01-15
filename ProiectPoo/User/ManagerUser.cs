
class ManagerUser
{
    private List<User> userList = new List<User>();
    private int userIdCounter = 1;

    public void Register(string userName, string password)
    {
        User newUser = new User(userIdCounter++, userName, password);
        userList.Add(newUser);
        Console.Writeline($"User'{userName}' registered successfully'.");
    }
    public bool Login(string userName, string password)
    {
        foreach (var user in userList)
        {
            if (user.UserName == userName && user.Password == password)
            {
                Console.Writeline($"Login successful for user '{userName}'.");
                return true;
            }
        }
        Console.WriteLine("Invalide username or password.");
        return false;
    }

    public void AddAccount(string userName, string password, boll isAdmin)
    {
        User newUser = new User(userIdCounter++, userName, password, isAdmin);
        userList.Add(newUser);
        Console.WriteLine($"Admin added user '{userName}' successfully.");
    }

    public void DeleteAccount(int userId)
    {
        var user = uerList.Find(u => u.ID == userId);
        if (user != null)
        {
            ClearPendingOrders(userId);
            userList.Remove(user);
            Console.WriteLine($"User '{user.UserName}' deleted successfully.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void ModifyAccount(int userId, string newUserName, string newPassword)
    {
        var user = uerList.Find(u => u.ID == userId);
        if (user != null)
        {
            user.UserName = newUserName;
            user.Password = newPassword;
            Console.WriteLine($"User '{userId}' updated successfully.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    private void ClearPendingOrders(int userId)
    {
        Console.WriteLine($"Clearing pending orders for user ID: {userId}...");
    }
}