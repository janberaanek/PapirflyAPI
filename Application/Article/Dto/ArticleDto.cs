namespace Application.Article.Dto
{
    public class ArticleDto
    {
        public int ArticleId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string? Category { get; set; } = null;

        public decimal Price { get; set; }

        public string? Currency { get; set; } = null;
    }
}
