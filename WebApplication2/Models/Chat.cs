namespace WebApplication2.Models;

public class Chat
{
    public Pair UserPair;
    public List<Message>? Messages;

    public Chat(User first, User second, List<Message>? messages)
    {
        UserPair = new Pair(first, second);
        Messages = messages;
    }
    
}