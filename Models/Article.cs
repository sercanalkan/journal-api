namespace JournalApi.Models;

public class Article : BaseModel
{
    public Guid UserId { get; set; }
    public Guid CategoryId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
}