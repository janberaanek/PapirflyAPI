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
            new Domain.Article { Id = 1, Name = "First Article", Description = "This is the content of the first article." },
            new Domain.Article { Id = 2, Name = "Second Article", Description = "This is the content of the second article." },
            new Domain.Article { Id = 3, Name = "Third Article", Description = "This is the content of the third article." }
        };
    }
}
