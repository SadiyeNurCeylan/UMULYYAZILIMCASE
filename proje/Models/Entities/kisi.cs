using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proje.Models.Entities
{
    [Table("kisiler")]

    public class kisi
    {
        public int id { get; set; }
        [DisplayName("Ad")]
        public string ad { get; set; }
        [DisplayName("Soyad")]
        public string soyad { get; set; }
        [DisplayName("E-Mail")]
        public string email { get; set; }

        [DisplayName("Mod")]
        public int modid { get; set; }
        public mod Mod { get; set; }

        [DisplayName("Hareket Şekli")]
        public int hareketid { get; set; }
        public hareket Hareket { get; set; }

        [DisplayName("Teslimat Şekli")]
        public int teslimatid { get; set; }
        public teslimat Teslimat { get; set; }

        [DisplayName("Paket Tipi")]
        public int paketid { get; set; }
        public paket Paket { get; set; }

        [DisplayName("Birim")]
        public int birimid { get; set; }
        public birim Birim { get; set; }

        [DisplayName("Ünite")]
        public int uniteid { get; set; }
        public unite Unite { get; set; }

        [DisplayName("Para Birimi")]
        public int paraid { get; set; }
        public para Para { get; set; }

        [DisplayName("Şehir")]
        public int sehirid { get; set; }
        public sehir Sehir { get; set; }
    }
}