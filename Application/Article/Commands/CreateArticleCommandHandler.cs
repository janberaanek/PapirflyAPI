using AutoMapper;
using MediatR;

namespace Application.Article.Commands
{
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, int>
    {
        private readonly ArticleStore _store;
        private readonly IMapper _mapper;

        public CreateArticleCommandHandler(ArticleStore store, IMapper mapper)
        {
            _store = store;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {            
            var article = _mapper.Map<Domain.Article>(request);

            // generate Id, simulating SQL
            article.Id = _store.Articles.Any() ? _store.Articles.Max(a => a.Id) + 1 : 1;
            
            _store.Articles.Add(article);

            return await Task.FromResult(article.Id);
        }
    }
}
