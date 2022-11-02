using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proje.Models.Entities
{
    [Table("hareketler")]
    public class hareket
    {
        public int id { get; set; }
        public string Hareket { get; set; }
    }
}