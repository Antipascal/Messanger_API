namespace WebApplication2.Models;

public class Message
{
    public string Content;
    public DateTime Timestamp;
    public bool isRead;

    public Message(string content, DateTime time)
    {
        Content = content;
        Timestamp = time;
        isRead = false;
    }
}