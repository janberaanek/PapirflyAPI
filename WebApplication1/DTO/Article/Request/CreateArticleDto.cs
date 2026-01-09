namespace WebApplication1.DTO.Article.Request
{
    public class CreateArticleDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
        public string? Currency { get; set; }
    }
}