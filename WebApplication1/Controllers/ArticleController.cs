using Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO.Article;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {        
        private IList<Article> _articles = new List<Article>
        {
            new Article { article_id = 1, name = "First Article", description = "This is the content of the first article." },
            new Article { article_id = 2, name = "Second Article", description = "This is the content of the second article." },
            new Article { article_id = 3, name = "Third Article", description = "This is the content of the third article." }
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public ArticleController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Articles")]
        public ActionResult<ArticleListDto> Get(string? queryString)
        {
            var list = new ArticleListDto() {  Items = _articles.Select(a => new ArticleDto() { article_id = a.article_id, name = a.name, description = a.description, category = a.category, price = a.price, currency = a.currency }).ToList() };
            return Ok(list);
        }
    }
}
