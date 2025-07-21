using mvc_intermediate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Documents;

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

            List < Urun > urunler = new List<Urun>() 
            {
                new Urun(){UrunID=1, UrunAdi="Samsung S6", Aciklama="idare eder", Satista_mi=true},
                new Urun(){UrunID=2, UrunAdi="Samsung S7", Aciklama="idare eder", Satista_mi=true},
                new Urun(){UrunID=3, UrunAdi="Samsung S8", Aciklama="idare eder", Satista_mi=false},
                new Urun(){UrunID=4, UrunAdi="Iphone 6", Aciklama="idare eder", Satista_mi=true},
                new Urun(){UrunID=5, UrunAdi="Iphone 7", Aciklama="idare eder", Satista_mi=true},
                new Urun(){UrunID=6, UrunAdi="Iphone 7", Aciklama="idare eder", Satista_mi=false},
                new Urun(){UrunID=7, UrunAdi="Iphone 7", Aciklama="idare eder", Satista_mi=true},
            };
            return View(urunler);
        }
    }
}