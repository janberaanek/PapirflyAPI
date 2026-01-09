using AutoMapper;

namespace Application.Article.Dto
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Domain.Article, ArticleListItemDto>();
        }

    }
}