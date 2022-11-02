using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proje.Models.Entities
{
    [Table("paketler")]
    public class paket
    {
        public int id { get; set; }
        public string Paket { get; set; }
    }
}