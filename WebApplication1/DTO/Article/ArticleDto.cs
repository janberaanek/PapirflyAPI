namespace WebApplication1.DTO.Article
{
    public class ArticleDto
    {
        public int article_id { get; set; }
        
        public string name { get; set; } = string.Empty;
        
        public string description { get; set; } = string.Empty;

        public string? category { get; set; } = null;

        public int price { get; set; }

        public string? currency { get; set; } = null;
    }
}
