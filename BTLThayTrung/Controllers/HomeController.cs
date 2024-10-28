using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTLThayTrung.Models;

namespace BTLThayTrung.Controllers
{
    public class HomeController : Controller
    {
        Model1 model = new Model1();
        // GET: Home
        public ActionResult Index(login log)
        {
            var check = model.logins.Where(x => x.user == log.user && x.pass == log.pass).Count();
            if (check > 0)
            {
                return RedirectToAction("Home");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Home()
        {
            var list = model.People.ToList();
            return View(list);
        }
        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Person model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new Model1();
                context.People.Add(model);
                context.SaveChanges();
                return RedirectToAction("Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new Model1();
            var old_data = context.People.Find(id);
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Person model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new Model1();
                var old_data = context.People.Find(model.id);
                old_data.name = model.name;
                old_data.date = model.date;
                old_data.address = model.address;
                context.SaveChanges();

                return RedirectToAction("Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new Model1();
            var delete = context.People.Find(id);
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var context = new Model1();
                var delete = context.People.Find(id);
                context.People.Remove(delete);
                context.SaveChanges();
                return RedirectToAction("Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
