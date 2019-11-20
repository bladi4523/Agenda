using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Agenda.Models;

namespace Agenda.Controllers
{
    public class contactoesController : Controller
    {
        private FaceEntities db = new FaceEntities();

        // GET: contactoes

        public ActionResult Index(string searching1)
        {
            var contactos = from n in db.contacto
                          select n;
            if (!String.IsNullOrEmpty(searching1))
            {
                contactos = contactos.Where(n => n.Nombre.Contains(searching1));
            }
            return View(contactos.ToList());
        }

        // GET: contactoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contacto contacto = db.contacto.Find(id);
            if (contacto == null)
            {
                return HttpNotFound();
            }
            return View(contacto);
        }

        // GET: contactoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: contactoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCon,Nombre,Celular,Email,Direccion")] contacto contacto)
        {
            if (ModelState.IsValid)
            {
                db.contacto.Add(contacto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contacto);
        }

        // GET: contactoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contacto contacto = db.contacto.Find(id);
            if (contacto == null)
            {
                return HttpNotFound();
            }
            return View(contacto);
        }

        // POST: contactoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCon,Nombre,Celular,Email,Direccion")] contacto contacto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contacto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contacto);
        }

        // GET: contactoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            contacto contacto = db.contacto.Find(id);
            if (contacto == null)
            {
                return HttpNotFound();
            }
            return View(contacto);
        }

        // POST: contactoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            contacto contacto = db.contacto.Find(id);
            db.contacto.Remove(contacto);
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
