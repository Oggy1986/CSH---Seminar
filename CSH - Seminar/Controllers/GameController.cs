using CSH___Seminar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSH___Seminar.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index(string lstApps, int dopunskiBroj, bool showDopunski, int brojPrikaza = 0)
        {
            List<int> mojaLista = System.Web.Helpers.Json.Decode<List<int>>(lstApps);
            
            ViewBag.showDopunski = false;
            ViewBag.dopunskiBroj = null;
            Random rnd = new Random();

            int randomBroj = rnd.Next(1, 36);
            if (mojaLista.IndexOf(randomBroj) == -1)
            {
                if (mojaLista.Count < 6)
                {
                    mojaLista.Add(randomBroj);
                    ViewBag.brojPrikaza = brojPrikaza + 1;
                }
                else
                {
                    ViewBag.dopunskiBroj = randomBroj;
                    ViewBag.showDopunski = true;
                    ViewBag.brojPrikaza = brojPrikaza;
                }
            }

            ViewBag.listIWantToSend = mojaLista;

            return View();
        }

       
    }
}