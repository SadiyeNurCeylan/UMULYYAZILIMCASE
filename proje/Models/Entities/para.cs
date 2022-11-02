using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proje.Models.Entities
{
    [Table("paralar")]
    public class para
    {
        public int id { get; set; }
        public string Para { get; set; }
    }
}