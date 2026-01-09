using Application.Article.Dto;
using AutoMapper;
using MediatR;

namespace Application.Article.Queries
{
    public class GetArticlesQueryHandler : IRequestHandler<GetArticlesQuery, ArticleListDto>
    {
        private readonly IMapper _mapper;
        private readonly ArticleStore _store;

        public GetArticlesQueryHandler(            
            IMapper mapper, ArticleStore store)
        { 
            _mapper = mapper;
            _store = store;
        }

        public async Task<ArticleListDto> Handle(GetArticlesQuery request, CancellationToken cancellationToken)
        {
            var queryable = _store.Articles.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.Name))
            {
                queryable = queryable.Where(a =>
                    a.Name.Contains(request.Name, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(request.Category))
            {
                queryable = queryable.Where(a =>
                    a.Category.Equals(request.Category, StringComparison.OrdinalIgnoreCase));
            }   

            var articles = queryable.ToList();
            var result = new ArticleListDto
            {
                Items = _mapper.Map<List<ArticleListItemDto>>(articles)
            };            

            return await Task.FromResult(result);            
        }
    }
}