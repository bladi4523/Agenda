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
    public class GrupoesController : Controller
    {
        private FaceEntities db = new FaceEntities();

        // GET: Grupoes
        public ActionResult Index(string searching2)
        {
            var grupos = from n in db.Grupo
                            select n;
            if (!String.IsNullOrEmpty(searching2))
            {
                grupos = grupos.Where(n => n.Nombre.Contains(searching2));
            }
            return View(grupos.ToList());
        }

        // GET: Grupoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupo grupo = db.Grupo.Find(id);
            if (grupo == null)
            {
                return HttpNotFound();
            }
            return View(grupo);
        }

        // GET: Grupoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grupoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.

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
