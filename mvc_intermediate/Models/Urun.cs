using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_intermediate.Models
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public bool Satista_mi {  get; set; }
    }
}