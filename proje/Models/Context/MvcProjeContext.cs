using proje.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proje.Models.Context
{
    public class MvcProjeContext : DbContext
    {
        public MvcProjeContext(): base("Server=.;Database=ProjeDB;Trusted_Connection=true")
        {

        }
  

        public DbSet<kisi> kisiler { get; set; }
        public DbSet<mod> modlar { get; set; }
        public DbSet<hareket> hareketler { get; set; }
        public DbSet<teslimat> teslimatlar { get; set; }
        public DbSet<sehir> sehirler { get; set; }
        public DbSet<paket> paketler { get; set; }
        public DbSet<birim> birimler { get; set; }
        public DbSet<unite> uniteler { get; set; }
        public DbSet<para> paralar { get; set; }

    }
}