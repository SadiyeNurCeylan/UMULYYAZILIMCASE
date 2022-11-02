using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proje.Models.Entities
{
    [Table("birimler")]
    public class birim
    {
        public int id { get; set; }
        public string Birim { get; set; }
    }
}