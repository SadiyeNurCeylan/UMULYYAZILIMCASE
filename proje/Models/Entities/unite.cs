using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace proje.Models.Entities
{
    [Table("uniteler")]
    public class unite
    {
        public int id { get; set; }

        [DisplayName("Ünite")]
        public string Unite { get; set; }
    }
}