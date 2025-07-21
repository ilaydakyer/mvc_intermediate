using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_intermediate.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //gerçek senaryoda homecontroller;
            //veritabanına bağlanır ve bilgileri getirir.
            //getirilen bilgiler bir model içerisine yani 
            //bir sınıf içerisine aktarılır
            //ve bu model view'a gönderilir
            return View();
        }
    }
}