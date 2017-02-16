using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using waMvcDay12.Models;

namespace waMvcDay12.Controllers
{
    public class BukuController : Controller
    {
        private DBKoperasiBukuEntities context = new DBKoperasiBukuEntities();
        //
        // GET: /Buku/
        public ActionResult Index()
        {
            return View(context.Buku.ToList());
        }

        public ActionResult AddBuku()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddBuku(Buku mdl)
        {
            if (ModelState.IsValid)
            {
                Buku item = new Buku()
                {
                    //BukuID = Guid.NewGuid(),
                    Kd_Buku = mdl.Kd_Buku,
                    Nm_Buku = mdl.Nm_Buku,
                    Jml_Halaman = mdl.Jml_Halaman,
                    Kd_Jenis = mdl.Kd_Jenis
                };
                context.Buku.Add(item);
                try
                {
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception)
                {
                    
                }
            }
            return View(mdl);
        }
	}
}