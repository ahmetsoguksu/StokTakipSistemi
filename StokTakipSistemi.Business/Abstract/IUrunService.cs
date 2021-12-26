﻿using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Business.Abstract
{
    public interface IUrunService
    {
        List<tbl_urun> GetAll();
        List<tbl_urun> GetProductsByCategory(int Kategori_id);
    }
}
