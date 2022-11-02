using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proje.Models.Entities
{
    [Table("sehirler")]
    public class sehir
    {
        public int id { get; set; }
        [DisplayName("Şehir")]
        public string Sehiradi { get; set; }

        [DisplayName("Ülke")]
        public string Ulke { get; set; }
    }
}