using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.DataAccess.Abstract
{
    public interface Itbl_urunDal
    {
        List<tbl_urun> GetAll();
        tbl_urun Get(int id);
        void Add(tbl_urun urun);
        void Update(tbl_urun urun);
        void Delete(tbl_urun urun);
    }
}
