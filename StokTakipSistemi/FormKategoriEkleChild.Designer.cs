
namespace StokTakipSistemi
{
    partial class FormKategoriEkleChild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tboxEklenecekKategori = new System.Windows.Forms.TextBox();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxEklenecekKategori
            // 
            this.tboxEklenecekKategori.Location = new System.Drawing.Point(138, 20);
            this.tboxEklenecekKategori.Name = "tboxEklenecekKategori";
            this.tboxEklenecekKategori.Size = new System.Drawing.Size(231, 22);
            this.tboxEklenecekKategori.TabIndex = 1;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.BackColor = System.Drawing.Color.IndianRed;
            this.btnKategoriEkle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKategoriEkle.Location = new System.Drawing.Point(0, 58);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(381, 40);
            this.btnKategoriEkle.TabIndex = 2;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            // 
            // FormKategoriEkleChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 98);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.tboxEklenecekKategori);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKategoriEkleChild";
            this.Text = "Yeni Kategori Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxEklenecekKategori;
        private System.Windows.Forms.Button btnKategoriEkle;
    }
}