using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1Progra3QUIZ.Models;

namespace WebApplication1Progra3QUIZ.Controllers
{
    public class MOVIMIENTOSController : Controller
    {
        private QUIZP3Entities1 db = new QUIZP3Entities1();

        // GET: MOVIMIENTOS
        public ActionResult Index()
        {
            return View(db.MOVIMIENTOS.ToList());
        }

        // GET: MOVIMIENTOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOVIMIENTOS mOVIMIENTOS = db.MOVIMIENTOS.Find(id);
            if (mOVIMIENTOS == null)
            {
                return HttpNotFound();
            }
            return View(mOVIMIENTOS);
        }

        // GET: MOVIMIENTOS/Create
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,idviajero,fecha,destino,origen,tiposolicitud,idusuario")] MOVIMIENTOS mOVIMIENTOS)
        {
            if (ModelState.IsValid)
            {
                db.MOVIMIENTOS.Add(mOVIMIENTOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mOVIMIENTOS);
        }

        // GET: MOVIMIENTOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOVIMIENTOS mOVIMIENTOS = db.MOVIMIENTOS.Find(id);
            if (mOVIMIENTOS == null)
            {
                return HttpNotFound();
            }
            return View(mOVIMIENTOS);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,idviajero,fecha,destino,origen,tiposolicitud,idusuario")] MOVIMIENTOS mOVIMIENTOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mOVIMIENTOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mOVIMIENTOS);
        }

        // GET: MOVIMIENTOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOVIMIENTOS mOVIMIENTOS = db.MOVIMIENTOS.Find(id);
            if (mOVIMIENTOS == null)
            {
                return HttpNotFound();
            }
            return View(mOVIMIENTOS);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MOVIMIENTOS mOVIMIENTOS = db.MOVIMIENTOS.Find(id);
            db.MOVIMIENTOS.Remove(mOVIMIENTOS);
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
