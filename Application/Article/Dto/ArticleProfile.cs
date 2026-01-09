using Application.Article.Commands;
using AutoMapper;

namespace Application.Article.Dto
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<Domain.Article, ArticleListItemDto>().ForMember(dest =>dest.ArticleId, opt => opt.MapFrom(src => src.Id));
            CreateMap<Domain.Article, ArticleDto>().ForMember(dest => dest.ArticleId, opt => opt.MapFrom(src => src.Id));

            CreateMap<CreateArticleCommand, Domain.Article>();
        }
    }
}