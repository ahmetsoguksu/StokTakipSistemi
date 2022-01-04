using FluentValidation;
using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Business.ValidationRules.FluentValidation
{
    public class UrunValidator:AbstractValidator<tbl_urun>
    {
        public UrunValidator()
        {
            RuleFor(p => p.urun_ad).NotEmpty();
            RuleFor(p => p.urun_birim).NotEmpty();
            RuleFor(p => p.urun_kdv_orani).NotEmpty();
            RuleFor(p => p.urun_son_satis_fiyati).NotEmpty();
            RuleFor(p => p.kategori_id).NotEmpty();

            RuleFor(p => p.urun_son_satis_fiyati).GreaterThan(0);
            RuleFor(p => p.urun_stok_miktari).GreaterThanOrEqualTo(0);

        }
    }
}
