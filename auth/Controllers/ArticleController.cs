using auth.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace auth.Controllers
{
    public class ArticleController : Controller
    {
    
        public  List<Article> Articles = new List<Article>() {
                new Article
                {
                    Id =1,
                    Title = "مقاله شماره 1",
                    Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ"
                },
                new Article
                {
                    Id =2,
                    Title = "مقاله شماره 2",
                    Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ"
                },
                new Article
                {
                    Id =3,
                    Title = "مقاله شماره 3",
                    Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ"
                }
            };
        // GET: Article
        public ActionResult Index()
        {

            //List<Article> Articles = new List<Article>() { 
            //    new Article
            //    {
            //        Id =1,
            //        Title = "مقاله شماره 1",
            //        Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ"
            //    },
            //    new Article
            //    {
            //        Id =2,
            //        Title = "مقاله شماره 2",
            //        Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ"
            //    },
            //    new Article
            //    {
            //        Id =3,
            //        Title = "مقاله شماره 3",
            //        Description = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ"
            //    }
            //};

  

            return View(Articles);
        }

        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            Article article = Articles.Find(x => x.Id == id);
  
            return View(article);
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(Article collection)
        {
            return Content(collection.Title);
            //try
            //{
            //    // TODO: Add insert logic here

            //    return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            Article article = Articles.Find(x => x.Id == id);

            return View(article);
        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
      
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            Article article = Articles.Find(x => x.Id == id);

            return View(article);
        }

        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Article article = Articles.Find(x => x.Id == id);

                Articles.Remove(article);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
