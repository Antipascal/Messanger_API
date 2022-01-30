using System.Text.Json.Serialization;

namespace WebApplication2.Models;

public class User
{
    public User(string login, string password, int? uid, string? token, List<Chat>? chats)
    {
        Login = login;
        Password = password;
        UID = uid;
        Token = token;
        Chats = chats;
    }

    public bool CheckPassword(UserForm user)
    {
        return user.Password != null && user.Login != null && 
               this.Login == user.Login && this.Password == user.Password;
    }

    public string Login { get; set; }

    public string Password { get; set; }

    public int? UID { get; set; }

    public List<Chat>? Chats { get; set; }

    public string? Token { get; set; }
}

public class UserForm
{
    [JsonPropertyName("login")]
    public string? Login { get; set; }
    
    [JsonPropertyName("password")]
    public string? Password { get; set; }
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