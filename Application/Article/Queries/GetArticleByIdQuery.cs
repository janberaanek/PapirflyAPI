using Application.Article.Dto;
using MediatR;

namespace Application.Article.Queries
{
    public class GetArticleByIdQuery : IRequest<ArticleDto>
    {
        public int Id { get; set; }
    }
}