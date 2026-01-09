using Application.Article.Dto;
using MediatR;

namespace Application.Article.Queries
{
    public class GetArticlesQuery : IRequest<ArticleListDto>
    {
        public string? Name { get; set; }

        public string? Category { get; set; }
    }
}
