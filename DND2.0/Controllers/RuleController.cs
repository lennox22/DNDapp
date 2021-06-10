using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DND2._0.Controllers
{
    public class RuleController : Controller
    {
        // GET: Rule
        public ActionResult Index()
        {
            return View();
        }

        // GET: Rule/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rule/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rule/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rule/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rule/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rule/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rule/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
