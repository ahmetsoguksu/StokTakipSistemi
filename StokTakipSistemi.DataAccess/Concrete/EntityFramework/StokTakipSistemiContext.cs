using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.DataAccess.Concrete.EntityFramework
{
    public class StokTakipSistemiContext:DbContext
    {
        public StokTakipSistemiContext()
            : base ("StsConnection")
        {

        }
        public DbSet<tbl_urun> Urunler { get; set; }
    }
    public class StokTakipSistemiContextKullanici : DbContext
    {
        public DbSet<tbl_kullanici> Kullanicilar { get; set; }
    }
}
