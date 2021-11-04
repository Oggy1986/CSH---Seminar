using CSH___Seminar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSH___Seminar.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<int> mojaLista = new List<int>();
            
            ViewBag.listIWantToSend = mojaLista;
            return View();
        }

    }
}