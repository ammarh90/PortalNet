using DemoPage.Database.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DemoPage.Database.Config
{
    public class CategoryConfig:EntityTypeConfiguration<Category>
    {
        public CategoryConfig()
        {   
            //property for category
            Property(item => item.Name).HasMaxLength(255).IsRequired();
        }
    }
}