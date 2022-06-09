using JournalApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace JournalApi.Controllers;

[ApiController]
[Route("articles")]
public class ArticleController : ControllerBase
{
    [HttpGet]
    public List<Article> GetList()
    {
        List<Article> article = new List<Article>();
        article.Add(new Article
        {
            Id = Guid.NewGuid(), CategoryId = Guid.NewGuid(), UserId = Guid.NewGuid(), Title = "Matematik",
            Content = "2+2=4"
        });
        article.Add(new Article
        {
            Id = Guid.NewGuid(), CategoryId = Guid.NewGuid(), UserId = Guid.NewGuid(), Title = "Diferansiyel",
            Content = "2+2=5"
        });
        return article;
    }

    [HttpGet("{id}")]
    public Article Get(Guid id)
    {
        var article = new Article
        {
            Id = Guid.NewGuid(), CategoryId = Guid.NewGuid(), UserId = Guid.NewGuid(), Title = "Diferansiyel",
            Content = "2+2=5"
        };

        return article;
    }
    
    [HttpPost]
    public Article Post(Article article)
    {
        return article;
    }
    
    [HttpPut("{id}")]
    public bool Put(Guid id, Article article)
    {
        return true;
    }
    
    [HttpDelete("{id}")]
    public bool Delete(Guid id)
    {
        return true;
    }
}