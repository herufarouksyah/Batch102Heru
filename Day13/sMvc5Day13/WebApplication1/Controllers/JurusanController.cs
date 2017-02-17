using clMvc5Day13.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class JurusanController : Controller
    {
        //
        // GET: /Jurusan/
        public ActionResult Index()
        {
            KampusContext db = new KampusContext();
            List<Jurusan> model = db.Jurusans.ToList();

            return View(model);
        }
	}
}