namespace WebApplication1.DTO.Article.Response
{
    public class ArticleListDto
    {
        public IList<ArticleDto> Items { get; set; } = new List<ArticleDto>();
    }
}
