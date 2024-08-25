using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Munipocollay_InformesTecnicos.Controllers
{
    public class AutenticationController : Controller
    {
        // GET: Autentication
        public ActionResult Login()
        {
            return View();
        }
    }
}