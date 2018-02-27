using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace DemoPage.Database.Config
{
    public class SettingConfig:EntityTypeConfiguration<Setting>
    {
        public SettingConfig()
        {
            Property(item => item.PageTitle).HasMaxLength(255).IsRequired();
        }
    }
}