using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPage.Database.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool IsFeatured { get; set; }

        public virtual List<Article> Articles { get; set; }

    }
}