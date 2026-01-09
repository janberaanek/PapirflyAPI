namespace WebApplication1.DTO.Article
{
    public class ArticleListDto
    {
        public IList<ArticleDto> Items { get; set; } = new List<ArticleDto>();
    }
}
