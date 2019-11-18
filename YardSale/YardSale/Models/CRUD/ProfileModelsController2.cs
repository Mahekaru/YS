using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YardSale.Models;

namespace YardSale.Models.CRUD
{
    public class ProfileModelsController2 : Controller
    {
        private YSDatabaseEntities db = new YSDatabaseEntities();

        // GET: ProfileModelsController2
        public ActionResult Index()
        {
            return View(db.ProfileModels.ToList());
        }

        // GET: ProfileModelsController2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfileModel profileModel = db.ProfileModels.Find(id);
            if (profileModel == null)
            {
                return HttpNotFound();
            }
            return View(profileModel);
        }

        // GET: ProfileModelsController2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfileModelsController2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Username,Password,Email,City,State,Phone,Address1,Address2,Zipcode")] ProfileModel profileModel)
        {
            if (ModelState.IsValid)
            {
                db.ProfileModels.Add(profileModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(profileModel);
        }

        // GET: ProfileModelsController2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfileModel profileModel = db.ProfileModels.Find(id);
            if (profileModel == null)
            {
                return HttpNotFound();
            }
            return View(profileModel);
        }

        // POST: ProfileModelsController2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Username,Password,Email,City,State,Phone,Address1,Address2,Zipcode")] ProfileModel profileModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profileModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profileModel);
        }

        // GET: ProfileModelsController2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfileModel profileModel = db.ProfileModels.Find(id);
            if (profileModel == null)
            {
                return HttpNotFound();
            }
            return View(profileModel);
        }

        // POST: ProfileModelsController2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProfileModel profileModel = db.ProfileModels.Find(id);
            db.ProfileModels.Remove(profileModel);
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
