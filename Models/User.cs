namespace JournalApi.Models;

public class User : BaseModel
{
    public string EmailAddress { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}