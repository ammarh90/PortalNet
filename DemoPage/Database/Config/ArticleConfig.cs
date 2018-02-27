using DemoPage.Database.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DemoPage.Database.Config
{
    public class ArticleConfig:EntityTypeConfiguration<Article>
    {
        public ArticleConfig()

        {   //property for article
            Property(item => item.Title).HasMaxLength(255).IsRequired();
            Property(item => item.Content).IsMaxLength().IsOptional();
            Property(item => item.Image).IsMaxLength().IsOptional();

            //one to many connection
            HasRequired(item => item.Category).WithMany(item => item.Articles).HasForeignKey(item => item.CategoryId);

        }
    }
}