using DemoPage.Database;
using DemoPage.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPage.ViewModels
{
    public class HomeIndexViewModel : BaseViewModels
    {
        //list of Featured Categories
        public List<Category> FeaturedCategories { get; set; }

        public HomeIndexViewModel()
        {
            
             // Load categories from database
            using (var dtx= new DataContext())
            {
                //featured categories
                this.FeaturedCategories = dtx.Categories.Where(item => item.IsFeatured == true).ToList();
            }

        }

        /// <summary>
        /// Uzmi zadnja 3 clanka iz kategorije
        /// </summary>
        /// <param name="id">Id Kategorije</param>
        /// <returns></returns>
        public List<Article> GetLastThreeArticles(int id)
        {
            using (var dtx = new DataContext())
            {
                return dtx.Articles.Where(item => item.CategoryId == id).OrderByDescending(item => item.ArticleId).Take(3).ToList();
            }

        }
    }
}