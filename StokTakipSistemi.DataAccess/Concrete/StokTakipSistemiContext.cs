using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.DataAccess.Concrete
{
    public class StokTakipSistemiContext:DbContext
    {
        public StokTakipSistemiContext()
            : base ("StsConnection")
        {

        }
        public DbSet<tbl_urun> Urunler { get; set; }
    }
}
