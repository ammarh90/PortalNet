using DemoPage.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPage.Database
{
    public class DemoDataFromDb
    {
        public DemoDataFromDb(DataContext context)
        {
            Setting setting = new Setting()
            {
                PageTitle = "DemoPage",
                IsDemoInitalized = true,
            };
            context.Settings.Add(setting);
            context.SaveChanges();

            //demo category
            Category cat1 = new Category()
            {
                Name = "Vijesti",
                IsFeatured = true

            };

            Category cat2 = new Category()
            {
                Name = "Sport",
                IsFeatured = true

            };

            Category cat3 = new Category()
            {
                Name = "Lifestyle",
                IsFeatured = true

            };

            Category cat4 = new Category()
            {
                Name = "Magazin",

            };

            Category cat5 = new Category()
            {
                Name = "Biznis",

            };

            Category cat6 = new Category()
            {
                Name = "Auto",

            };

            Category cat7 = new Category()
            {
                Name = "Zanimljivosti",

            };

            //add catategory to database
            context.Categories.Add(cat1);
            context.Categories.Add(cat2);
            context.Categories.Add(cat3);
            context.Categories.Add(cat4);
            context.Categories.Add(cat5);
            context.Categories.Add(cat6);
            context.Categories.Add(cat7);

            // Save categories to database
            context.SaveChanges();

            for (int i = 1; i <= 3; i++)
            {
                Article article = new Article()
                {
                    CategoryId = cat1.CategoryId,
                    Title = "Clanak " + i,
                    Content = "Ovdje ide sadrzaj"
                };
                context.Articles.Add(article);
                context.SaveChanges();


            }

            for (int i = 1; i <= 3; i++)
            {
                Article article = new Article()
                {
                    CategoryId = cat2.CategoryId,
                    Title = "Clanak " + i,
                    Content = "Ovdje ide sadrzaj"
                };
                context.Articles.Add(article);
                context.SaveChanges();
            }
            for (int i = 1; i <= 3; i++)
            {
                Article article = new Article()
                {
                    CategoryId = cat3.CategoryId,
                    Title = "Clanak " + i,
                    Content = "Ovdje ide sadrzaj"
                };
                context.Articles.Add(article);
                context.SaveChanges();
            }
        }
    }
}