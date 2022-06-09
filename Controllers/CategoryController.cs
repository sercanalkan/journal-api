using JournalApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace JournalApi.Controllers;

[ApiController]
[Route("categories")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    public List<Category> GetList()
    {
        List<Category> categories = new List<Category>();
        categories.Add(new Category
        {
            Id = Guid.NewGuid(), Name = "Genel"
        });
        categories.Add(new Category
        {
            Id = Guid.NewGuid(), Name = "Özel"
        });
        return categories;
    }

    [HttpGet("{id}")]
    public Category Get(Guid id)
    {
        var category = new Category
        {
            Id = Guid.NewGuid(), Name = "Özel"
        };

        return category;
    }
    
    [HttpPost]
    public Category Post(Category category)
    {
        return category;
    }
    
    [HttpPut("{id}")]
    public bool Put(Guid id, Category category)
    {
        return true;
    }
    
    [HttpDelete("{id}")]
    public bool Delete(Guid id)
    {
        return true;
    }
}