using StokTakipSistemi.Business.Abstract;
using StokTakipSistemi.Business.Concrete;
using StokTakipSistemi.Business.DependencyResolvers.Ninject;
using StokTakipSistemi.DataAccess.Concrete.EntityFramework;
using StokTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class FormYetkili : Form
    {
        public FormYetkili()
        {
            InitializeComponent();
            _urunService = InstanceFactory.GetInstance<IUrunService>();
            _kategoriService = InstanceFactory.GetInstance<IKategoriService>();
        }
        public IUrunService _urunService;
        public IKategoriService _kategoriService;
        private void FormYetkili_Load(object sender, EventArgs e)
        {
            LoadProductsYetkili();
            LoadCategoriesYetkili();
        }

        private void LoadCategoriesYetkili()
        {
            cboxKategori.DataSource = _kategoriService.GetAll();
            cboxKategori.DisplayMember = "kategori_ad";
            cboxKategori.ValueMember = "kategori_id";

            cboxKategoriAlim.DataSource = _kategoriService.GetAll();
            cboxKategoriAlim.DisplayMember = "kategori_ad";
            cboxKategoriAlim.ValueMember = "kategori_id";

            cboxKategoriStok.DataSource = _kategoriService.GetAll();
            cboxKategoriStok.DisplayMember = "kategori_ad";
            cboxKategoriStok.ValueMember = "kategori_id";

            cboxEditUrunKategori.DataSource = _kategoriService.GetAll();
            cboxEditUrunKategori.DisplayMember = "kategori_ad";
            cboxEditUrunKategori.ValueMember = "kategori_id";

            dgwEditKategoriListesi.DataSource = _kategoriService.GetAll();
        }

        public void LoadProductsYetkili()
        {
            dgwSatisUrunListesi.DataSource = _urunService.GetAll();
            dgwAlimUrunListesi.DataSource = _urunService.GetAll();
            dgwStokUrunListesi.DataSource = _urunService.GetAll();
            dgwSatisUrunListesi.DataSource = _urunService.GetAll();
            dgwEditUrunListesi.DataSource = _urunService.GetAll();
        }

        private void cboxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwSatisUrunListesi.DataSource = _urunService.GetProductsByCategory(Convert.ToInt32(cboxKategori.SelectedValue));
            }
            catch
            {
            }        
        }

        private void cboxKategoriAlim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwAlimUrunListesi.DataSource = _urunService.GetProductsByCategory(Convert.ToInt32(cboxKategoriAlim.SelectedValue));
            }
            catch
            {
            }
        }

        private void cboxKategoriStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwStokUrunListesi.DataSource = _urunService.GetProductsByCategory(Convert.ToInt32(cboxKategoriStok.SelectedValue));
            }
            catch
            {
            }
        }

        private void cboxEditUrunKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    dgwEditUrunListesi.DataSource = _urunService.GetProductsByCategory(Convert.ToInt32(cboxEditUrunKategori.SelectedValue));
            //}
            //catch
            //{
            //}
        }

        private void tboxUrunAdi_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tboxUrunAdi.Text))
            {
                dgwSatisUrunListesi.DataSource = _urunService.GetProductsByProductName(tboxUrunAdi.Text);
            }
            else
            {
                LoadProductsYetkili();
            }
        }

        private void tboxUrunAdiAlim_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tboxUrunAdiAlim.Text))
            {
                dgwAlimUrunListesi.DataSource = _urunService.GetProductsByProductName(tboxUrunAdiAlim.Text);
            }
            else
            {
                LoadProductsYetkili();
            }
        }

        private void tboxUrunAdiArama_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tboxUrunAdiArama.Text))
            {
                dgwStokUrunListesi.DataSource = _urunService.GetProductsByProductName(tboxUrunAdiArama.Text);
            }
            else
            {
                LoadProductsYetkili();
            }
        }

        private void tboxEditUrunSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tboxEditUrunSearch.Text))
            {
                dgwEditUrunListesi.DataSource = _urunService.GetProductsByProductName(tboxEditUrunSearch.Text);
            }
            else
            {
                LoadProductsYetkili();
            }
        }

        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            FormUrunEkleChild formUrunEkleChild = new FormUrunEkleChild();
            formUrunEkleChild.Owner = this;
            formUrunEkleChild.Show();
        }

        private void btnEditUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _urunService.Add(new tbl_urun
                {
                    kategori_id = Convert.ToInt32(cboxEditUrunKategori.SelectedValue),
                    urun_ad = tBoxEditUrunAdi.Text,
                    urun_son_satis_fiyati = Convert.ToDecimal(tboxEditUrunFiyat.Text),
                    urun_birim = tboxEditUrunBirim.Text,
                    urun_stok_miktari = Convert.ToInt32(tboxEditUrunStok.Text),
                    urun_kdv_orani = Convert.ToDecimal(tboxEditUrunKdvOrani.Text)
                });
                MessageBox.Show("Ürün Kaydedildi!");
                TboxClear();
                LoadProductsYetkili();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void TboxClear()
        {
            tBoxEditUrunAdi.Text = "";
            tboxEditUrunFiyat.Text = "";
            tboxEditUrunBirim.Text = "";
            tboxEditUrunStok.Text = "";
            tboxEditUrunKdvOrani.Text = "";
        }

        private void btnEditUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _urunService.Update(new tbl_urun
                {
                    urun_id = Convert.ToInt32(dgwEditUrunListesi.CurrentRow.Cells[0].Value),
                    urun_ad = tBoxEditUrunAdi.Text,
                    kategori_id = Convert.ToInt32(cboxEditUrunKategori.SelectedValue),
                    urun_birim = tboxEditUrunBirim.Text,
                    urun_kdv_orani = Convert.ToDecimal(tboxEditUrunKdvOrani.Text),
                    urun_son_satis_fiyati = Convert.ToDecimal(tboxEditUrunFiyat.Text),
                    urun_son_alis_fiyati = Convert.ToDecimal(dgwEditUrunListesi.CurrentRow.Cells[6].Value),
                    urun_stok_miktari = Convert.ToInt32(dgwEditUrunListesi.CurrentRow.Cells[4].Value)

                });
                MessageBox.Show("Ürün Bilgileri Güncellendi!");
                TboxClear();
                LoadProductsYetkili();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void dgwEditUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBoxEditUrunId.Text = dgwEditUrunListesi.CurrentRow.Cells[0].Value.ToString();
            tBoxEditUrunAdi.Text = dgwEditUrunListesi.CurrentRow.Cells[1].Value.ToString();
            cboxEditUrunKategori.SelectedValue = dgwEditUrunListesi.CurrentRow.Cells[2].Value;
            tboxEditUrunBirim.Text = dgwEditUrunListesi.CurrentRow.Cells[3].Value.ToString();
            tboxEditUrunStok.Text = dgwEditUrunListesi.CurrentRow.Cells[4].Value.ToString();
            tboxEditUrunKdvOrani.Text = dgwEditUrunListesi.CurrentRow.Cells[5].Value.ToString();
            tboxEditUrunFiyat.Text = dgwEditUrunListesi.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnEditUrunSil_Click(object sender, EventArgs e)
        {
            try
            {
                _urunService.Delete(new tbl_urun
                {
                    urun_id = Convert.ToInt32(dgwEditUrunListesi.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Ürün (" + tBoxEditUrunAdi.Text + ") Silindi!");
                TboxClear();
                LoadProductsYetkili();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void dgwEditKategoriListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


