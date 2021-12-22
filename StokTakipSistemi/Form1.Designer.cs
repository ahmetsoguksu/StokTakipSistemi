
namespace StokTakipSistemi
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tboxParola = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblUyari = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Takip Sistemi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parola:";
            // 
            // tboxKullaniciAdi
            // 
            this.tboxKullaniciAdi.Location = new System.Drawing.Point(149, 100);
            this.tboxKullaniciAdi.Name = "tboxKullaniciAdi";
            this.tboxKullaniciAdi.Size = new System.Drawing.Size(142, 22);
            this.tboxKullaniciAdi.TabIndex = 3;
            // 
            // tboxParola
            // 
            this.tboxParola.Location = new System.Drawing.Point(149, 147);
            this.tboxParola.Name = "tboxParola";
            this.tboxParola.Size = new System.Drawing.Size(142, 22);
            this.tboxParola.TabIndex = 4;
            // 
            // btnGiris
            // 
            this.btnGiris.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGiris.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(0, 239);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(308, 49);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblUyari
            // 
            this.lblUyari.BackColor = System.Drawing.Color.FloralWhite;
            this.lblUyari.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUyari.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUyari.Location = new System.Drawing.Point(0, 205);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(308, 34);
            this.lblUyari.TabIndex = 6;
            this.lblUyari.Text = "label4";
            this.lblUyari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUyari.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 288);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.tboxParola);
            this.Controls.Add(this.tboxKullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Stok Takip Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxKullaniciAdi;
        private System.Windows.Forms.TextBox tboxParola;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblUyari;
    }
}

