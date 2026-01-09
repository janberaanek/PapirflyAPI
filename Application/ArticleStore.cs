using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ArticleStore
    {
        public IList<Domain.Article> Articles = new List<Domain.Article>
        {
            new Domain.Article { article_id = 1, name = "First Article", description = "This is the content of the first article." },
            new Domain.Article { article_id = 2, name = "Second Article", description = "This is the content of the second article." },
            new Domain.Article { article_id = 3, name = "Third Article", description = "This is the content of the third article." }
        };
    }
}
