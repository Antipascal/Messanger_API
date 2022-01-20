namespace WebApplication2.Models;

public class User
{
    public User(string login, string password, int? uid)
    {
        Login = login;
        Password = password;
        UID = uid;
        Chats = null;
    }

    public bool CheckPassword(UserForm user)
    {
        return user.Password != null && user.Login != null && 
               this.Login == user.Login && this.Password == user.Password;
    }

    public string Login { get; }

    private string Password;
    
    public int? UID { get; }

    public List<Chat>? Chats;
}

public class UserForm
{
    public string? Login;
    public string? Password;

    public UserForm(string? login, string? password)
    {
        Login = login;
        Password = password;
    }
}

public struct Pair
{
    public User First;
    public User Second;
    
    public Pair(User first, User second)
    {
        First = first;
        Second = second;
    }
}