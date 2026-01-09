using Application.Article.Dto;
using AutoMapper;
using MediatR;

namespace Application.Article.Queries
{
    public class GetArticleByIdQueryHandler : IRequestHandler<GetArticleByIdQuery, ArticleDto>
    {
        private readonly ArticleStore _store;
        private IMapper _mapper;

        public GetArticleByIdQueryHandler(ArticleStore store, IMapper mapper)
        {
            _store = store;            
            _mapper = mapper;
        }
        public async Task<ArticleDto> Handle(GetArticleByIdQuery request, CancellationToken cancellationToken)
        {
            var queryable = _store.Articles.AsQueryable();
            var article = queryable.FirstOrDefault(a => a.Id == request.Id);            

            var result = _mapper.Map<ArticleDto>(article);
            return await Task.FromResult(result);
        }
    }
}