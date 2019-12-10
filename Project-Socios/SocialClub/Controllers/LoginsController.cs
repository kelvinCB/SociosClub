using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SocialClub.Models;

namespace SocialClub.Controllers
{
    public class LoginsController : Controller
    {
        private SocialClubDBEntities db = new SocialClubDBEntities();

        // GET: Logins
        public ActionResult Index()
        {
            return View(db.tbLogins.ToList());
        }

        // GET: Logins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbLogin tbLogin = db.tbLogins.Find(id);
            if (tbLogin == null)
            {
                return HttpNotFound();
            }
            return View(tbLogin);
        }

        // GET: Logins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Logins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Email,Contrasena,FechaCreacion")] tbLogin tbLogin)
        {
            if (ModelState.IsValid)
            {
                db.tbLogins.Add(tbLogin);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(tbLogin);
        }

        // GET: Logins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbLogin tbLogin = db.tbLogins.Find(id);
            if (tbLogin == null)
            {
                return HttpNotFound();
            }
            return View(tbLogin);
        }

        // POST: Logins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Email,Contrasena,FechaCreacion")] tbLogin tbLogin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbLogin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbLogin);
        }

        // GET: Logins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbLogin tbLogin = db.tbLogins.Find(id);
            if (tbLogin == null)
            {
                return HttpNotFound();
            }
            return View(tbLogin);
        }

        // POST: Logins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbLogin tbLogin = db.tbLogins.Find(id);
            db.tbLogins.Remove(tbLogin);
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
