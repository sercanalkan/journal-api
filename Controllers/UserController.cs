using JournalApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace JournalApi.Controllers;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
    [HttpGet]
    public List<User> GetList()
    {
        List<User> users = new List<User>();
        users.Add(new User { Id = Guid.NewGuid(), EmailAddress = "sercan@gmail.com",Firstname = "Sercan", Lastname = "Alkan", Age = 20 });
        users.Add(new User { Id = Guid.NewGuid(), EmailAddress = "sertan@gmail.com",Firstname = "Sertan", Lastname = "Alkan", Age = 20 });
        users.Add(new User { Id = Guid.NewGuid(), EmailAddress = "evren@gmail.com",Firstname = "Evren", Lastname = "Bla", Age = 20 });
        return users;
    }

    [HttpGet("{id}")]
    public User Get(Guid id)
    {
        var user = new User
        {
            Id = Guid.NewGuid(), EmailAddress = "sercan@gmail.com", Firstname = "Sercan", Lastname = "Alkan", Age = 20
        };

        return user;
    }
    
    [HttpPost]
    public User Post(User user)
    {
        return user;
    }
    
    [HttpPut("{id}")]
    public bool Put(Guid id, User user)
    {
        return true;
    }
    
    [HttpDelete("{id}")]
    public bool Delete(Guid id)
    {
        return true;
    }
}