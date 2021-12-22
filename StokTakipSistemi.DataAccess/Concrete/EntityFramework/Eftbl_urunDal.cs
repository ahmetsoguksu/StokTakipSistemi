using StokTakipSistemi.DataAccess.Abstract;
using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.DataAccess.Concrete.EntityFramework
{
    public class Eftbl_urunDal:Itbl_urunDal
    {
        public List<tbl_urun> GetAll()
        {
            using (StokTakipSistemiContext context = new StokTakipSistemiContext())
            {
                return context.Urunler.ToList();
            }
        }
        public tbl_urun Get(int id)
        {
            using (StokTakipSistemiContext context = new StokTakipSistemiContext())
            {
                return context.Urunler.SingleOrDefault(p => p.urun_id == id);
            }
        }
        public void Add(tbl_urun urun)
        {
            using (StokTakipSistemiContext context = new StokTakipSistemiContext())
            {
                context.Urunler.Add(urun);
                context.SaveChanges();
            }
        }
        public void Update(tbl_urun urun)
        {

        }
        public void Delete(tbl_urun urun)
        {

        }
    }
}
