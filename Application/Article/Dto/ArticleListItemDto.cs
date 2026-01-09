using Application.Article.Dto;
using Domain;

namespace Application.Article.Dto
{
    public class ArticleListItemDto
    {
        public int ArticleId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string? Category { get; set; } = null;

        public int Price { get; set; }

        public string? Currency { get; set; } = null;
    }
}