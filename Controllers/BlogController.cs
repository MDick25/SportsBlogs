using BlogApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApplication.Controllers
{
    public class BlogController : Controller
    {
        BlogDB db = new BlogDB();

        public ActionResult Index()
        {
            ViewBag.CurrentDateTime = String.Format("{0:yyyy-MM-dd}", DateTime.Now);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Index(Blog blog)
        {
            if(ModelState.IsValid)
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
                ViewBag.CurrentDateTime = String.Format("{0:yyyy-MM-dd}", DateTime.Now);
                return RedirectToAction("Index");
            }
            return View(blog);
        }
        public ActionResult Create()
        {
            ViewBag.CurrentTime = String.Format("{0:yyyy-MM-dd}", DateTime.Now);
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult ListOfEmployee()
        {
            var bloglist = db.Blogs.Where(x => x.active == true).OrderBy(x => x.blogid);

            return PartialView(bloglist);

        }
        public ActionResult Details(int id)
        {
            var bloglist = db.Blogs.Find(id);

            return View(bloglist);
        }
        public ActionResult Edit(int id)
        {
            var blog = db.Blogs.Find(id);
            ViewBag.CurrentTime = String.Format("{0:yyyy-MM-dd}", DateTime.Now);
            return View(blog);
        }
        [HttpPost]
        public ActionResult Edit(Blog blog)
        {
            if(ModelState.IsValid)
            {
                db.Entry(blog).State = EntityState.Modified;
                db.SaveChanges();
                ViewBag.CurrentTime = String.Format("{0:yyyy-MM-dd}", DateTime.Now);

                return RedirectToAction("Index");
            }
            return View(blog);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var blog_details = db.Blogs.Find(id);
            return View(blog_details);
        }
        [HttpPost]
        public ActionResult Delete(int blogId, bool active = false)
        {
            var update_blog = db.Blogs.Where(x => x.blogid == blogId).First();

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}