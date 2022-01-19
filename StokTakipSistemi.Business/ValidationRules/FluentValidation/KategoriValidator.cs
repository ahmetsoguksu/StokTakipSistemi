using FluentValidation;
using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Business.ValidationRules.FluentValidation
{
    class KategoriValidator:AbstractValidator<tbl_kategori>
    {
        public KategoriValidator()
        {
            RuleFor(p => p.kategori_ad).NotEmpty();
            RuleFor(p => p.kategori_id).NotEmpty();
        }
        
    }
}
