using Application.Article.Commands;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO.Article.Request;
using WebApplication1.DTO.Article.Response;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/articles")]
    public class ArticleController : ControllerBase
    {                
        private readonly ILogger<ArticleController> _logger;
        private readonly IMediator _mediator;

        public ArticleController(ILogger<ArticleController> logger, IMediator mediator)
        {
            _logger = logger;
            this._mediator = mediator;
        }

        /// <summary>
        /// Get articles based on search criteria
        /// </summary>
        /// <param name="queryDto">Search criteria</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<ArticleListDto>> GetAsync([FromQuery] GetArticlesQueryDto? queryDto)
        {
            var query = new Application.Article.Queries.GetArticlesQuery
            {
                Name = queryDto?.Name,
                Category = queryDto?.Category
            };

            var result = await _mediator.Send(query);
            return Ok(result);
        }

        /// <summary>
        /// Returns a single article based on the ID provided.
        /// </summary>
        /// <param name="id">Id of the article</param>
        /// <returns>Returns the article if found</returns>
        /// <response code="200">Returns the article if found.</response>
        /// <response code="404">If the article with provided ID is not found.</response>
        [ProducesResponseType(typeof(ArticleDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{article-id}")]
        public async Task<ActionResult<ArticleDto>> GetByIdAsync([FromRoute(Name = "article-id")] int articleId)
        {
            var query = new Application.Article.Queries.GetArticleByIdQuery
            {
                Id = articleId
            };
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound(new { Message = $"Article with {articleId} not found." });
            }
            return Ok(result);
        }

        /// <summary>
        /// Adds a new article to the store.
        /// </summary>
        /// <param name="dto">Details of the article</param>
        /// <returns>ID of the newly created article</returns>
        [HttpPost]
        public async Task<ActionResult> AddArticle([FromBody] CreateArticleDto dto)
        {
            var command = new CreateArticleCommand
            {
                Name = dto.Name,
                Description = dto.Description,
                Category = dto.Category,
                Price = dto.Price,
                Currency = dto.Currency
            };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
