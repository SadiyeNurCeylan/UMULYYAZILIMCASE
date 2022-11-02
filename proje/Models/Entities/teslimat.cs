using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proje.Models.Entities
{
    [Table("teslimatlar")]
    public class teslimat
    {
        public int id { get; set; }
        public string Teslimat { get; set; }
    }
}