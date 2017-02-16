using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using waMvcDay12.Models;

namespace waMvcDay12.Controllers
{
    public class ProfileController : Controller
    {
        //
        // GET: /Profile/
        public static List<Models.Profile> listProfile = new List<Models.Profile>();

        public ActionResult Index()
        {
            return View(listProfile);
        }

        public ActionResult Detail ()
        {
            Models.Profile item = new Models.Profile()
            {
                ID = 1,
                NamaLengkap = "Fullan bin Fullan",
                Alamat = "Jakarta",
                Hobi  = "Belajar C#"
            };
            return View(item);
        }

        public ActionResult AddProfile()
        {
            return View();
        }

        [HttpPost]
        public  ActionResult AddProfile(Models.Profile mdl)
        {
            listProfile.Add(mdl);
            return View("Detail",mdl);
        }
	}
}