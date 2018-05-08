using DemoPage.Database.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DemoPage.Database.Config
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            Property(item => item.FirstName).HasMaxLength(255).IsRequired();
            Property(item => item.LastName).HasMaxLength(255).IsRequired();
            Property(item => item.UserName).HasMaxLength(50).IsRequired();
            Property(item => item.Password).HasMaxLength(255).IsRequired();
        }
    }
}