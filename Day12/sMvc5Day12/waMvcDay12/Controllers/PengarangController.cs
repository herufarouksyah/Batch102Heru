using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace waMvcDay12.Controllers
{
    public class PengarangController : Controller
    {
        //
        // GET: /Pengarang/
        public static List<Models.Pengarang> listPengarang = new List<Models.Pengarang>();
        public ActionResult Index()
        {
            return View(listPengarang);
        }

        public ActionResult Detail()
        {
            return View();
        }

        public ActionResult Tambah()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Tambah(Models.Pengarang pengarang)
        {
            listPengarang.Add(pengarang);
            return View("Detail", pengarang);
        }


	}
}