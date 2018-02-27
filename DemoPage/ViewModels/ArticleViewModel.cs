using DemoPage.Database;
using DemoPage.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPage.ViewModels
{
    public class ArticleViewModel : BaseViewModels
    {
        public Article Article { get; set; }

        public ArticleViewModel(int id)
        {
            using(var dtx= new DataContext())
            {
                //first Article in data
                this.Article = dtx.Articles.Where(item => item.ArticleId == id).FirstOrDefault();

                // Increase views on article
                this.Article.Views = this.Article.Views+1;
                dtx.SaveChanges();

                
            }
        }
    }
}