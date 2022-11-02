using proje.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje.Models.kisimodel
{
    public class KisiDetayViewModel
    {
        public kisi kisi { get; set; }
        public List<mod> modlar { get; set; }
        public List<hareket> hareketler { get; set; }
        public List<teslimat> teslimatlar { get; set; }
        public List<sehir> sehirler { get; set; }
        public List<paket> paketler { get; set; }
        public List<birim> birimler { get; set; }
        public List<unite> uniteler { get; set; }
        public List<para> paralar { get; set; }

    }
}