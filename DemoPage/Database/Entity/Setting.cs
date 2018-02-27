using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPage.Database
{
    public class Setting
    {
        public int SettingId { get; set; }
        public string PageTitle { get; set; }
        public bool IsDemoInitalized { get; set; }
    }
}