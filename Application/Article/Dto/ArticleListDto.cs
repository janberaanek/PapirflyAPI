using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Article.Dto
{
    public class ArticleListDto
    {
        public IList<ArticleListItemDto> Items { get; set; } = [];
    }
}
