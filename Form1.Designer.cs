namespace AluminyumTakipSistemi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMalzeme = new System.Windows.Forms.TabPage();
            this.grpMalzemeGiris = new System.Windows.Forms.GroupBox();
            this.lblMalzemeAdi = new System.Windows.Forms.Label();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.lblMalzemeCinsi = new System.Windows.Forms.Label();
            this.txtMalzemeCinsi = new System.Windows.Forms.TextBox();
            this.lblBirimi = new System.Windows.Forms.Label();
            this.txtBirimi = new System.Windows.Forms.TextBox();
            this.lblFiyati = new System.Windows.Forms.Label();
            this.txtFiyati = new System.Windows.Forms.TextBox();
            this.lblStokAdedi = new System.Windows.Forms.Label();
            this.txtStokAdedi = new System.Windows.Forms.TextBox();
            this.lblTeminFirma = new System.Windows.Forms.Label();
            this.txtTeminFirma = new System.Windows.Forms.TextBox();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.btnMalzemeSil = new System.Windows.Forms.Button();
            this.btnMalzemeGuncelle = new System.Windows.Forms.Button();
            this.btnMalzemeTemizle = new System.Windows.Forms.Button();
            this.txtMalzemeAra = new System.Windows.Forms.TextBox();
            this.btnMalzemeAra = new System.Windows.Forms.Button();
            this.lstMalzemeler = new System.Windows.Forms.ListBox();
            this.tabTeklif = new System.Windows.Forms.TabPage();
            this.lblTeklifNo = new System.Windows.Forms.Label();
            this.txtTeklifNo = new System.Windows.Forms.TextBox();
            this.lblTeklifFirma = new System.Windows.Forms.Label();
            this.txtTeklifFirma = new System.Windows.Forms.TextBox();
            this.lblProjeAdi = new System.Windows.Forms.Label();
            this.txtProjeAdi = new System.Windows.Forms.TextBox();
            this.lblCmbMalzeme = new System.Windows.Forms.Label();
            this.cmbTeklifMalzeme = new System.Windows.Forms.ComboBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.btnTeklifeMalzemeEkle = new System.Windows.Forms.Button();
            this.btnMalzemeKalemiCikar = new System.Windows.Forms.Button();
            this.lstTeklifKalemleri = new System.Windows.Forms.ListBox();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.btnFiyatHesapla = new System.Windows.Forms.Button();
            this.btnTeklifKaydet = new System.Windows.Forms.Button();
            this.btnTeklifSil = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.grpTeklifAra = new System.Windows.Forms.GroupBox();
            this.txtTeklifAra = new System.Windows.Forms.TextBox();
            this.btnTeklifAra = new System.Windows.Forms.Button();
            this.lstKayitliTeklifler = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabMalzeme.SuspendLayout();
            this.grpMalzemeGiris.SuspendLayout();
            this.tabTeklif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            this.grpTeklifAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMalzeme);
            this.tabControl1.Controls.Add(this.tabTeklif);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMalzeme
            // 
            this.tabMalzeme.Controls.Add(this.lstMalzemeler);
            this.tabMalzeme.Controls.Add(this.btnMalzemeTemizle);
            this.tabMalzeme.Controls.Add(this.btnMalzemeGuncelle);
            this.tabMalzeme.Controls.Add(this.btnMalzemeSil);
            this.tabMalzeme.Controls.Add(this.btnMalzemeEkle);
            this.tabMalzeme.Controls.Add(this.btnMalzemeAra);
            this.tabMalzeme.Controls.Add(this.txtMalzemeAra);
            this.tabMalzeme.Controls.Add(this.grpMalzemeGiris);
            this.tabMalzeme.Location = new System.Drawing.Point(4, 25);
            this.tabMalzeme.Name = "tabMalzeme";
            this.tabMalzeme.Size = new System.Drawing.Size(952, 541);
            this.tabMalzeme.TabIndex = 0;
            this.tabMalzeme.Text = "Malzeme Yönetimi";
            // 
            // grpMalzemeGiris
            // 
            this.grpMalzemeGiris.Controls.Add(this.lblMalzemeAdi);
            this.grpMalzemeGiris.Controls.Add(this.txtMalzemeAdi);
            this.grpMalzemeGiris.Controls.Add(this.lblMalzemeCinsi);
            this.grpMalzemeGiris.Controls.Add(this.txtMalzemeCinsi);
            this.grpMalzemeGiris.Controls.Add(this.lblBirimi);
            this.grpMalzemeGiris.Controls.Add(this.txtBirimi);
            this.grpMalzemeGiris.Controls.Add(this.lblFiyati);
            this.grpMalzemeGiris.Controls.Add(this.txtFiyati);
            this.grpMalzemeGiris.Controls.Add(this.lblStokAdedi);
            this.grpMalzemeGiris.Controls.Add(this.txtStokAdedi);
            this.grpMalzemeGiris.Controls.Add(this.lblTeminFirma);
            this.grpMalzemeGiris.Controls.Add(this.txtTeminFirma);
            this.grpMalzemeGiris.Location = new System.Drawing.Point(10, 10);
            this.grpMalzemeGiris.Name = "grpMalzemeGiris";
            this.grpMalzemeGiris.Size = new System.Drawing.Size(726, 200);
            this.grpMalzemeGiris.TabIndex = 0;
            this.grpMalzemeGiris.TabStop = false;
            // 
            // lblMalzemeAdi
            // 
            this.lblMalzemeAdi.Location = new System.Drawing.Point(10, 22);
            this.lblMalzemeAdi.Name = "lblMalzemeAdi";
            this.lblMalzemeAdi.Size = new System.Drawing.Size(110, 20);
            this.lblMalzemeAdi.TabIndex = 0;
            this.lblMalzemeAdi.Text = "Malzeme Adı:";
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(130, 20);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(180, 22);
            this.txtMalzemeAdi.TabIndex = 1;
            // 
            // lblMalzemeCinsi
            // 
            this.lblMalzemeCinsi.Location = new System.Drawing.Point(10, 93);
            this.lblMalzemeCinsi.Name = "lblMalzemeCinsi";
            this.lblMalzemeCinsi.Size = new System.Drawing.Size(110, 20);
            this.lblMalzemeCinsi.TabIndex = 2;
            this.lblMalzemeCinsi.Text = "Malzeme Cinsi:";
            // 
            // txtMalzemeCinsi
            // 
            this.txtMalzemeCinsi.Location = new System.Drawing.Point(130, 90);
            this.txtMalzemeCinsi.Name = "txtMalzemeCinsi";
            this.txtMalzemeCinsi.Size = new System.Drawing.Size(180, 22);
            this.txtMalzemeCinsi.TabIndex = 3;
            // 
            // lblBirimi
            // 
            this.lblBirimi.Location = new System.Drawing.Point(10, 147);
            this.lblBirimi.Name = "lblBirimi";
            this.lblBirimi.Size = new System.Drawing.Size(110, 20);
            this.lblBirimi.TabIndex = 4;
            this.lblBirimi.Text = "Birimi:";
            this.lblBirimi.Click += new System.EventHandler(this.lblBirimi_Click);
            // 
            // txtBirimi
            // 
            this.txtBirimi.Location = new System.Drawing.Point(130, 144);
            this.txtBirimi.Name = "txtBirimi";
            this.txtBirimi.Size = new System.Drawing.Size(100, 22);
            this.txtBirimi.TabIndex = 5;
            // 
            // lblFiyati
            // 
            this.lblFiyati.Location = new System.Drawing.Point(10, 50);
            this.lblFiyati.Name = "lblFiyati";
            this.lblFiyati.Size = new System.Drawing.Size(110, 20);
            this.lblFiyati.TabIndex = 6;
            this.lblFiyati.Text = "Fiyatı (TL):";
            // 
            // txtFiyati
            // 
            this.txtFiyati.Location = new System.Drawing.Point(130, 50);
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.Size = new System.Drawing.Size(140, 22);
            this.txtFiyati.TabIndex = 7;
            // 
            // lblStokAdedi
            // 
            this.lblStokAdedi.Location = new System.Drawing.Point(337, 24);
            this.lblStokAdedi.Name = "lblStokAdedi";
            this.lblStokAdedi.Size = new System.Drawing.Size(90, 20);
            this.lblStokAdedi.TabIndex = 8;
            this.lblStokAdedi.Text = "Stok Adedi:";
            // 
            // txtStokAdedi
            // 
            this.txtStokAdedi.Location = new System.Drawing.Point(460, 24);
            this.txtStokAdedi.Name = "txtStokAdedi";
            this.txtStokAdedi.Size = new System.Drawing.Size(140, 22);
            this.txtStokAdedi.TabIndex = 9;
            // 
            // lblTeminFirma
            // 
            this.lblTeminFirma.Location = new System.Drawing.Point(337, 66);
            this.lblTeminFirma.Name = "lblTeminFirma";
            this.lblTeminFirma.Size = new System.Drawing.Size(117, 20);
            this.lblTeminFirma.TabIndex = 10;
            this.lblTeminFirma.Text = "Temin Firması:";
            // 
            // txtTeminFirma
            // 
            this.txtTeminFirma.Location = new System.Drawing.Point(466, 66);
            this.txtTeminFirma.Name = "txtTeminFirma";
            this.txtTeminFirma.Size = new System.Drawing.Size(140, 22);
            this.txtTeminFirma.TabIndex = 11;
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.Location = new System.Drawing.Point(757, 24);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(100, 28);
            this.btnMalzemeEkle.TabIndex = 0;
            this.btnMalzemeEkle.Text = "Ekle";
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // btnMalzemeSil
            // 
            this.btnMalzemeSil.Location = new System.Drawing.Point(757, 68);
            this.btnMalzemeSil.Name = "btnMalzemeSil";
            this.btnMalzemeSil.Size = new System.Drawing.Size(100, 28);
            this.btnMalzemeSil.TabIndex = 1;
            this.btnMalzemeSil.Text = "Sil";
            this.btnMalzemeSil.Click += new System.EventHandler(this.btnMalzemeSil_Click);
            // 
            // btnMalzemeGuncelle
            // 
            this.btnMalzemeGuncelle.Location = new System.Drawing.Point(757, 113);
            this.btnMalzemeGuncelle.Name = "btnMalzemeGuncelle";
            this.btnMalzemeGuncelle.Size = new System.Drawing.Size(100, 28);
            this.btnMalzemeGuncelle.TabIndex = 2;
            this.btnMalzemeGuncelle.Text = "Güncelle";
            this.btnMalzemeGuncelle.Click += new System.EventHandler(this.btnMalzemeGuncelle_Click);
            // 
            // btnMalzemeTemizle
            // 
            this.btnMalzemeTemizle.Location = new System.Drawing.Point(757, 167);
            this.btnMalzemeTemizle.Name = "btnMalzemeTemizle";
            this.btnMalzemeTemizle.Size = new System.Drawing.Size(100, 28);
            this.btnMalzemeTemizle.TabIndex = 3;
            this.btnMalzemeTemizle.Text = "Temizle";
            this.btnMalzemeTemizle.Click += new System.EventHandler(this.btnMalzemeTemizle_Click);
            // 
            // txtMalzemeAra
            // 
            this.txtMalzemeAra.Location = new System.Drawing.Point(23, 266);
            this.txtMalzemeAra.Name = "txtMalzemeAra";
            this.txtMalzemeAra.Size = new System.Drawing.Size(460, 22);
            this.txtMalzemeAra.TabIndex = 0;
            // 
            // btnMalzemeAra
            // 
            this.btnMalzemeAra.Location = new System.Drawing.Point(510, 266);
            this.btnMalzemeAra.Name = "btnMalzemeAra";
            this.btnMalzemeAra.Size = new System.Drawing.Size(100, 28);
            this.btnMalzemeAra.TabIndex = 1;
            this.btnMalzemeAra.Text = "Ara";
            this.btnMalzemeAra.Click += new System.EventHandler(this.btnMalzemeAra_Click);
            // 
            // lstMalzemeler
            // 
            this.lstMalzemeler.ItemHeight = 16;
            this.lstMalzemeler.Location = new System.Drawing.Point(20, 383);
            this.lstMalzemeler.Name = "lstMalzemeler";
            this.lstMalzemeler.Size = new System.Drawing.Size(885, 116);
            this.lstMalzemeler.TabIndex = 0;
            this.lstMalzemeler.SelectedIndexChanged += new System.EventHandler(this.lstMalzemeler_SelectedIndexChanged);
            // 
            // tabTeklif
            // 
            this.tabTeklif.Controls.Add(this.lstKayitliTeklifler);
            this.tabTeklif.Controls.Add(this.btnTeklifKaydet);
            this.tabTeklif.Controls.Add(this.lblCmbMalzeme);
            this.tabTeklif.Controls.Add(this.btnTeklifSil);
            this.tabTeklif.Controls.Add(this.lblTeklifNo);
            this.tabTeklif.Controls.Add(this.btnRapor);
            this.tabTeklif.Controls.Add(this.cmbTeklifMalzeme);
            this.tabTeklif.Controls.Add(this.txtTeklifNo);
            this.tabTeklif.Controls.Add(this.lblAdet);
            this.tabTeklif.Controls.Add(this.lblTeklifFirma);
            this.tabTeklif.Controls.Add(this.numAdet);
            this.tabTeklif.Controls.Add(this.txtTeklifFirma);
            this.tabTeklif.Controls.Add(this.btnTeklifeMalzemeEkle);
            this.tabTeklif.Controls.Add(this.lblProjeAdi);
            this.tabTeklif.Controls.Add(this.btnMalzemeKalemiCikar);
            this.tabTeklif.Controls.Add(this.txtProjeAdi);
            this.tabTeklif.Controls.Add(this.lstTeklifKalemleri);
            this.tabTeklif.Controls.Add(this.lblToplamFiyat);
            this.tabTeklif.Controls.Add(this.btnFiyatHesapla);
            this.tabTeklif.Controls.Add(this.grpTeklifAra);
            this.tabTeklif.Location = new System.Drawing.Point(4, 25);
            this.tabTeklif.Name = "tabTeklif";
            this.tabTeklif.Size = new System.Drawing.Size(952, 541);
            this.tabTeklif.TabIndex = 1;
            this.tabTeklif.Text = "Teklif Yönetimi";
            this.tabTeklif.Click += new System.EventHandler(this.tabTeklif_Click);
            // 
            // lblTeklifNo
            // 
            this.lblTeklifNo.Location = new System.Drawing.Point(18, 25);
            this.lblTeklifNo.Name = "lblTeklifNo";
            this.lblTeklifNo.Size = new System.Drawing.Size(70, 20);
            this.lblTeklifNo.TabIndex = 0;
            this.lblTeklifNo.Text = "Teklif No:";
            // 
            // txtTeklifNo
            // 
            this.txtTeklifNo.Location = new System.Drawing.Point(109, 22);
            this.txtTeklifNo.Name = "txtTeklifNo";
            this.txtTeklifNo.Size = new System.Drawing.Size(80, 22);
            this.txtTeklifNo.TabIndex = 1;
            // 
            // lblTeklifFirma
            // 
            this.lblTeklifFirma.Location = new System.Drawing.Point(229, 27);
            this.lblTeklifFirma.Name = "lblTeklifFirma";
            this.lblTeklifFirma.Size = new System.Drawing.Size(70, 20);
            this.lblTeklifFirma.TabIndex = 2;
            this.lblTeklifFirma.Text = "Firma Adı:";
            // 
            // txtTeklifFirma
            // 
            this.txtTeklifFirma.Location = new System.Drawing.Point(305, 23);
            this.txtTeklifFirma.Name = "txtTeklifFirma";
            this.txtTeklifFirma.Size = new System.Drawing.Size(130, 22);
            this.txtTeklifFirma.TabIndex = 3;
            this.txtTeklifFirma.TextChanged += new System.EventHandler(this.txtTeklifFirma_TextChanged);
            // 
            // lblProjeAdi
            // 
            this.lblProjeAdi.Location = new System.Drawing.Point(552, 27);
            this.lblProjeAdi.Name = "lblProjeAdi";
            this.lblProjeAdi.Size = new System.Drawing.Size(70, 20);
            this.lblProjeAdi.TabIndex = 4;
            this.lblProjeAdi.Text = "Proje Adı:";
            this.lblProjeAdi.Click += new System.EventHandler(this.lblProjeAdi_Click);
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Location = new System.Drawing.Point(620, 27);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(115, 22);
            this.txtProjeAdi.TabIndex = 5;
            // 
            // lblCmbMalzeme
            // 
            this.lblCmbMalzeme.Location = new System.Drawing.Point(33, 105);
            this.lblCmbMalzeme.Name = "lblCmbMalzeme";
            this.lblCmbMalzeme.Size = new System.Drawing.Size(70, 20);
            this.lblCmbMalzeme.TabIndex = 0;
            this.lblCmbMalzeme.Text = "Malzeme:";
            // 
            // cmbTeklifMalzeme
            // 
            this.cmbTeklifMalzeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeklifMalzeme.Location = new System.Drawing.Point(109, 101);
            this.cmbTeklifMalzeme.Name = "cmbTeklifMalzeme";
            this.cmbTeklifMalzeme.Size = new System.Drawing.Size(355, 24);
            this.cmbTeklifMalzeme.TabIndex = 1;
            // 
            // lblAdet
            // 
            this.lblAdet.Location = new System.Drawing.Point(493, 105);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(40, 22);
            this.lblAdet.TabIndex = 2;
            this.lblAdet.Text = "Adet:";
            this.lblAdet.Click += new System.EventHandler(this.lblAdet_Click);
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(542, 105);
            this.numAdet.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(80, 22);
            this.numAdet.TabIndex = 3;
            this.numAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTeklifeMalzemeEkle
            // 
            this.btnTeklifeMalzemeEkle.Location = new System.Drawing.Point(801, 130);
            this.btnTeklifeMalzemeEkle.Name = "btnTeklifeMalzemeEkle";
            this.btnTeklifeMalzemeEkle.Size = new System.Drawing.Size(120, 28);
            this.btnTeklifeMalzemeEkle.TabIndex = 4;
            this.btnTeklifeMalzemeEkle.Text = "Teklife Ekle";
            this.btnTeklifeMalzemeEkle.Click += new System.EventHandler(this.btnTeklifeMalzemeEkle_Click);
            // 
            // btnMalzemeKalemiCikar
            // 
            this.btnMalzemeKalemiCikar.Location = new System.Drawing.Point(801, 164);
            this.btnMalzemeKalemiCikar.Name = "btnMalzemeKalemiCikar";
            this.btnMalzemeKalemiCikar.Size = new System.Drawing.Size(120, 28);
            this.btnMalzemeKalemiCikar.TabIndex = 5;
            this.btnMalzemeKalemiCikar.Text = "Çıkar";
            this.btnMalzemeKalemiCikar.Click += new System.EventHandler(this.btnMalzemeKalemiCikar_Click);
            // 
            // lstTeklifKalemleri
            // 
            this.lstTeklifKalemleri.ItemHeight = 16;
            this.lstTeklifKalemleri.Location = new System.Drawing.Point(21, 144);
            this.lstTeklifKalemleri.Name = "lstTeklifKalemleri";
            this.lstTeklifKalemleri.Size = new System.Drawing.Size(750, 100);
            this.lstTeklifKalemleri.TabIndex = 6;
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamFiyat.Location = new System.Drawing.Point(192, 259);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(144, 20);
            this.lblToplamFiyat.TabIndex = 7;
            this.lblToplamFiyat.Text = "Toplam: 0,00 TL";
            // 
            // btnFiyatHesapla
            // 
            this.btnFiyatHesapla.Location = new System.Drawing.Point(44, 258);
            this.btnFiyatHesapla.Name = "btnFiyatHesapla";
            this.btnFiyatHesapla.Size = new System.Drawing.Size(130, 28);
            this.btnFiyatHesapla.TabIndex = 8;
            this.btnFiyatHesapla.Text = "Fiyat Hesapla";
            this.btnFiyatHesapla.Click += new System.EventHandler(this.btnFiyatHesapla_Click);
            // 
            // btnTeklifKaydet
            // 
            this.btnTeklifKaydet.Location = new System.Drawing.Point(801, 216);
            this.btnTeklifKaydet.Name = "btnTeklifKaydet";
            this.btnTeklifKaydet.Size = new System.Drawing.Size(130, 28);
            this.btnTeklifKaydet.TabIndex = 0;
            this.btnTeklifKaydet.Text = "Teklifi Kaydet";
            this.btnTeklifKaydet.Click += new System.EventHandler(this.btnTeklifKaydet_Click);
            // 
            // btnTeklifSil
            // 
            this.btnTeklifSil.Location = new System.Drawing.Point(791, 432);
            this.btnTeklifSil.Name = "btnTeklifSil";
            this.btnTeklifSil.Size = new System.Drawing.Size(130, 28);
            this.btnTeklifSil.TabIndex = 1;
            this.btnTeklifSil.Text = "Teklifi Sil";
            this.btnTeklifSil.Click += new System.EventHandler(this.btnTeklifSil_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(791, 477);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(150, 28);
            this.btnRapor.TabIndex = 2;
            this.btnRapor.Text = "Raporu Görüntüle";
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // grpTeklifAra
            // 
            this.grpTeklifAra.Controls.Add(this.txtTeklifAra);
            this.grpTeklifAra.Controls.Add(this.btnTeklifAra);
            this.grpTeklifAra.Location = new System.Drawing.Point(10, 355);
            this.grpTeklifAra.Name = "grpTeklifAra";
            this.grpTeklifAra.Size = new System.Drawing.Size(920, 55);
            this.grpTeklifAra.TabIndex = 3;
            this.grpTeklifAra.TabStop = false;
            this.grpTeklifAra.Text = "Teklif Ara";
            // 
            // txtTeklifAra
            // 
            this.txtTeklifAra.Location = new System.Drawing.Point(10, 20);
            this.txtTeklifAra.Name = "txtTeklifAra";
            this.txtTeklifAra.Size = new System.Drawing.Size(460, 22);
            this.txtTeklifAra.TabIndex = 0;
            // 
            // btnTeklifAra
            // 
            this.btnTeklifAra.Location = new System.Drawing.Point(525, 14);
            this.btnTeklifAra.Name = "btnTeklifAra";
            this.btnTeklifAra.Size = new System.Drawing.Size(100, 28);
            this.btnTeklifAra.TabIndex = 1;
            this.btnTeklifAra.Text = "Ara";
            this.btnTeklifAra.Click += new System.EventHandler(this.btnTeklifAra_Click);
            // 
            // lstKayitliTeklifler
            // 
            this.lstKayitliTeklifler.ItemHeight = 16;
            this.lstKayitliTeklifler.Location = new System.Drawing.Point(21, 453);
            this.lstKayitliTeklifler.Name = "lstKayitliTeklifler";
            this.lstKayitliTeklifler.Size = new System.Drawing.Size(750, 52);
            this.lstKayitliTeklifler.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 595);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Alüminyum Doğrama - Teklif ve Fiyatlandırma Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMalzeme.ResumeLayout(false);
            this.tabMalzeme.PerformLayout();
            this.grpMalzemeGiris.ResumeLayout(false);
            this.grpMalzemeGiris.PerformLayout();
            this.tabTeklif.ResumeLayout(false);
            this.tabTeklif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            this.grpTeklifAra.ResumeLayout(false);
            this.grpTeklifAra.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMalzeme;
        private System.Windows.Forms.TabPage tabTeklif;

        private System.Windows.Forms.GroupBox grpMalzemeGiris;
        private System.Windows.Forms.Label lblMalzemeAdi, lblMalzemeCinsi, lblBirimi, lblFiyati, lblStokAdedi, lblTeminFirma;
        private System.Windows.Forms.TextBox txtMalzemeAdi, txtMalzemeCinsi, txtBirimi, txtFiyati, txtStokAdedi, txtTeminFirma, txtMalzemeAra;
        private System.Windows.Forms.Button btnMalzemeEkle, btnMalzemeSil, btnMalzemeGuncelle, btnMalzemeTemizle, btnMalzemeAra;
        private System.Windows.Forms.ListBox lstMalzemeler;

        private System.Windows.Forms.GroupBox grpTeklifAra;
        private System.Windows.Forms.Label lblTeklifNo, lblTeklifFirma, lblProjeAdi, lblCmbMalzeme, lblAdet, lblToplamFiyat;
        private System.Windows.Forms.TextBox txtTeklifNo, txtTeklifFirma, txtProjeAdi, txtTeklifAra;
        private System.Windows.Forms.ComboBox cmbTeklifMalzeme;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.Button btnTeklifeMalzemeEkle, btnMalzemeKalemiCikar, btnFiyatHesapla, btnTeklifKaydet, btnTeklifSil, btnRapor, btnTeklifAra;
        private System.Windows.Forms.ListBox lstTeklifKalemleri, lstKayitliTeklifler;
    }
}

