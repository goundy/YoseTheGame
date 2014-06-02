using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YoseTheGame.Controllers
{
    public class PingController : Controller
    {
        //
        // GET: /Ping/

        public ActionResult Index()
        {
            return Json(new { alive = true }, JsonRequestBehavior.AllowGet);
        }

    }
}
