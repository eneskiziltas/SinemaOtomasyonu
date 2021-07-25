using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriparkOopDegerlendirme2
{
    public class Koltuk
    {
        public string AdSoyad { get; set; }
        public string Tc { get; set; }
        public string Cinsiyet { get; set; }
        public Boolean Durum { get; set; }
        public Object Button { get; set; }

        public Koltuk(string ad, string tc, string cinsiyet, object button)
        {
            AdSoyad = ad;
            Tc = tc;
            Cinsiyet = cinsiyet;
            Durum = true;
            Button = button;
        }


    }
}
