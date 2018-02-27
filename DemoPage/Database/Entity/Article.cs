using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPage.Database.Entity
{
    public class Article
    {
        
        public int ArticleId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int Views { get; set; }

        public virtual Category Category { get; set; }

    }
}