using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
          

            ViewBag.Message = "Your application description page.";

            DataMessageContext context = new DataMessageContext();

         List<MessageTable> ListUser = (from a in context.MessageTable select a).ToList();

            return View(ListUser);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Chat()
        {
            return View();
        }
        public ActionResult CheckServer()
        {
            return View();
        }
        public ActionResult ChatAdmin()
        {
            return View();
        }
    }
}