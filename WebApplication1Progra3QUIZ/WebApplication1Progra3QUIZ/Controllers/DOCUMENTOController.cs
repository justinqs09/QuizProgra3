using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1Progra3QUIZ.Controllers
{
    public class DOCUMENTOController : Controller
    {
        private QUIZP3Entities1 db = new QUIZP3Entities1();

        // GET: DOCUMENTOes
        public ActionResult Index()
        {
            var dOCUMENTO = db.DOCUMENTO.Include(d => d.ESTADOS).Include(d => d.VIAJEROS);
            return View(dOCUMENTO.ToList());
        }

        // GET: DOCUMENTOes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOCUMENTO dOCUMENTO = db.DOCUMENTO.Find(id);
            if (dOCUMENTO == null)
            {
                return HttpNotFound();
            }
            return View(dOCUMENTO);
        }

        // GET: DOCUMENTOes/Create
        public ActionResult Create()
        {
            ViewBag.EstadoID = new SelectList(db.ESTADOS, "ID", "Descripcion");
            ViewBag.IdViajero = new SelectList(db.VIAJEROS, "ID", "Nombre");
            return View();
        }

        // POST: DOCUMENTOes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TipoDocumento,NumeroDocumento,FechaExpiracion,EstadoID,IdViajero")] DOCUMENTO dOCUMENTO)
        {
            if (ModelState.IsValid)
            {
                db.DOCUMENTO.Add(dOCUMENTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstadoID = new SelectList(db.ESTADOS, "ID", "Descripcion", dOCUMENTO.EstadoID);
            ViewBag.IdViajero = new SelectList(db.VIAJEROS, "ID", "Nombre", dOCUMENTO.IdViajero);
            return View(dOCUMENTO);
        }

        // GET: DOCUMENTOes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOCUMENTO dOCUMENTO = db.DOCUMENTO.Find(id);
            if (dOCUMENTO == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstadoID = new SelectList(db.ESTADOS, "ID", "Descripcion", dOCUMENTO.EstadoID);
            ViewBag.IdViajero = new SelectList(db.VIAJEROS, "ID", "Nombre", dOCUMENTO.IdViajero);
            return View(dOCUMENTO);
        }

        // POST: DOCUMENTOes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TipoDocumento,NumeroDocumento,FechaExpiracion,EstadoID,IdViajero")] DOCUMENTO dOCUMENTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dOCUMENTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstadoID = new SelectList(db.ESTADOS, "ID", "Descripcion", dOCUMENTO.EstadoID);
            ViewBag.IdViajero = new SelectList(db.VIAJEROS, "ID", "Nombre", dOCUMENTO.IdViajero);
            return View(dOCUMENTO);
        }

        // GET: DOCUMENTOes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DOCUMENTO dOCUMENTO = db.DOCUMENTO.Find(id);
            if (dOCUMENTO == null)
            {
                return HttpNotFound();
            }
            return View(dOCUMENTO);
        }

        // POST: DOCUMENTOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DOCUMENTO dOCUMENTO = db.DOCUMENTO.Find(id);
            db.DOCUMENTO.Remove(dOCUMENTO);
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
