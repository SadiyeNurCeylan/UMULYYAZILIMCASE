using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proje.Models.Entities
{
    [Table("modlar")]
    public class mod
    {
        public int id { get; set; }
        public string Mod { get; set; }
    }
}