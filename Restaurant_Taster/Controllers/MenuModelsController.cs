using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Restaurant_Taster.Models;

namespace Restaurant_Taster.Controllers
{
    public class MenuModelsController : Controller
    {
        private ResDBContext db = new ResDBContext();

        // GET: MenuModels
        public ActionResult Index()
        {
            return View(db.MenuDB.ToList());
        }

        // GET: MenuModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuModel menuModel = db.MenuDB.Find(id);
            if (menuModel == null)
            {
                return HttpNotFound();
            }
            return View(menuModel);
        }

        // GET: MenuModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MenuModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Customer,Table,TimeDate")] MenuModel menuModel)
        {
            if (ModelState.IsValid)
            {
                db.MenuDB.Add(menuModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menuModel);
        }

        // GET: MenuModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuModel menuModel = db.MenuDB.Find(id);
            if (menuModel == null)
            {
                return HttpNotFound();
            }
            return View(menuModel);
        }

        // POST: MenuModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Customer,Table,TimeDate")] MenuModel menuModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menuModel);
        }

        // GET: MenuModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuModel menuModel = db.MenuDB.Find(id);
            if (menuModel == null)
            {
                return HttpNotFound();
            }
            return View(menuModel);
        }

        // POST: MenuModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MenuModel menuModel = db.MenuDB.Find(id);
            db.MenuDB.Remove(menuModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
