using StokTakipSistemi.Business.Abstract;
using StokTakipSistemi.Business.Concrete;
using StokTakipSistemi.DataAccess.Concrete.EntityFramework;
using StokTakipSistemi.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class FormUrunEkleChild : Form
    {
        public FormUrunEkleChild()
        {
            InitializeComponent();
            _urunService = new UrunManager(new Eftbl_urunDal());
            _kategoriService = new KategoriManager(new Eftbl_kategoriDal());

        }
        public IUrunService _urunService;
        public IKategoriService _kategoriService;
        private void btnUrunuEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _urunService.Add(new tbl_urun
                {
                    kategori_id = Convert.ToInt32(cboxEklencekUrunKategori.SelectedValue),
                    urun_ad = tboxEklenecekUrunAdi.Text,
                    urun_son_satis_fiyati = Convert.ToDecimal(tboxEklenecekUrunBirimFiyat.Text),
                    urun_birim = tboxEklenecekUrunBirimTuru.Text,
                    urun_stok_miktari = Convert.ToInt32(tboxEklenecekUrunMevcutStok.Text),
                    urun_kdv_orani = Convert.ToDecimal(tboxEklenecekUrunKdvOrani.Text)
                });
                MessageBox.Show("Ürün Kaydedildi!");
                TboxClear();
                ((FormYetkili)this.Owner).LoadProductsYetkili();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void FormUrunEkleChild_Load(object sender, EventArgs e)
        {
            cboxEklencekUrunKategori.DataSource = _kategoriService.GetAll();
            cboxEklencekUrunKategori.DisplayMember = "kategori_ad";
            cboxEklencekUrunKategori.ValueMember = "kategori_id";
        }
        private void TboxClear()
        {
            tboxEklenecekUrunAdi.Text = "";
            tboxEklenecekUrunBirimFiyat.Text = "";
            tboxEklenecekUrunBirimTuru.Text = "";
            tboxEklenecekUrunKdvOrani.Text = "";
        }
    }
}
