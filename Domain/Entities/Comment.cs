namespace Domain.Entities;

public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int  UserId { get; set; }
    public User User { get; set; }
    
    public int  TodoId { get; set; }
    public Todo Todo { get; set; }
}