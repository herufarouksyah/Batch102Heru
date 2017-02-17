using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using waMvc5Day13.Models;

namespace waMvc5Day13.Controllers
{
    public class FakultasController : Controller
    {
        private DBSiakadEntities context = new DBSiakadEntities();
        //
        // GET: /Fakultas/
        public ActionResult Index()
        {
            return View(context.Fakultas.ToList());
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Fakultas mdl)
        {
            if (ModelState.IsValid)
            {
                Fakultas item = new Fakultas()
                {
                    Id = Guid.NewGuid(),
                    KodeFakultas = mdl.KodeFakultas,
                    NamaFakultas = mdl.NamaFakultas,

                };
                context.Fakultas.Add(item);
                try
                {
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    string s = e.Message;
                }
            }
            return View(mdl);
        }

        public ActionResult Edit(string id)
        {
            Guid fkId = Guid.Parse(id);
            Fakultas model = context.Fakultas.Find(fkId);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Fakultas mdl)
        {
            if (ModelState.IsValid)
            {
                Fakultas item = context.Fakultas.Find(mdl.Id);
                    if (item != null)
	                {
		                item.KodeFakultas = mdl.KodeFakultas;
                        item.NamaFakultas = mdl.NamaFakultas;
	                }
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
        public ActionResult Hapus(string id)
        {
            Guid fkid = Guid.Parse(id);
            Fakultas mdl = context.Fakultas.Find(fkid);
            return View(mdl);
        }

        [HttpPost, ActionName("Hapus")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteFakultas(string id)
        {
            Guid fkid = Guid.Parse(id);
            Fakultas mdl = context.Fakultas.Find(fkid);
            context.Fakultas.Remove(mdl);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(string id)
        {
            Guid fkid = Guid.Parse(id);
            Fakultas mdl = context.Fakultas.Find(fkid);
            return View(mdl);
        }

	}
}