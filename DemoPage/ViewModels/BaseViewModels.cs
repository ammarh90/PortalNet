using DemoPage.Database;
using DemoPage.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPage.ViewModels
{
    public class BaseViewModels
    {
        public List<Category> Categories { get; set; }
        public List<Article> MostViewed { get; set; }
        public Setting Settings { get; set; }


        public BaseViewModels()
        {
            using (var dtx= new DataContext())
            {
                //list of category
                this.Categories = dtx.Categories.ToList();

                //most viewed article
                this.MostViewed = dtx.Articles.OrderByDescending(item => item.Views).Take(5).ToList();

     
                this.Settings = dtx.Settings.FirstOrDefault();


            }
        }
    }
}