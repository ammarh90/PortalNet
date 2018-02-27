using DemoPage.Database;
using DemoPage.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPage.ViewModels
{
    public class CategoryViewModel:BaseViewModels
    {
        public List<Article> Articles { get; set; }

        public CategoryViewModel(int id)
        {
            using(var dtx= new DataContext())
            {

                this.Articles = dtx.Articles.Where(item => item.CategoryId==id).ToList();
            }
        }
    }
}