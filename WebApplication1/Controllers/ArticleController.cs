using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO.Article.Request;
using WebApplication1.DTO.Article.Response;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {                
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;

        public ArticleController(ILogger<WeatherForecastController> logger, IMediator mediator)
        {
            _logger = logger;
            this._mediator = mediator;
        }

        [HttpGet(Name = "Articles")]
        public async Task<ActionResult<ArticleListDto>> GetAsync([FromQuery] GetArticlesQueryDto? queryDto)
        {
            var query = new Application.Article.Queries.GetArticlesQuery
            {
                Name = queryDto?.Name
            };

            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
