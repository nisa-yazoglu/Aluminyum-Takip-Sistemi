using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AluminyumTakipSistemi
{
    public partial class Form1 : Form
    {
        private readonly string MalzemeDosyaYolu = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "malzemeler.txt");

        private readonly string TeklifDosyaYolu = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "teklifler.txt");

        private List<Malzeme> MalzemeListesi = new List<Malzeme>();

        private List<Teklif> TeklifListesi = new List<Teklif>();

        private Teklif GuncelTeklif = new Teklif();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeleriYukle();
            TeklifleriYukle();
        }

        private void MalzemeleriYukle()
        {
            MalzemeListesi.Clear();

            lstMalzemeler.Items.Clear();
            cmbTeklifMalzeme.Items.Clear();

            // Malzeme verilerini dosyadan okuyup forma, listelere aktarır.
            if (!File.Exists(MalzemeDosyaYolu)) return;

            foreach (string satir in File.ReadAllLines(MalzemeDosyaYolu))
            {
                string[] p = satir.Split('|');
                if (p.Length >= 6)
                {
                    Malzeme m = new Malzeme(p[0], p[1], p[2],
                        Convert.ToDouble(p[3]),
                        Convert.ToInt32(p[4]),
                        p[5],
                        p.Length > 6 ? p[6] : "");
                    MalzemeListesi.Add(m);

                    lstMalzemeler.Items.Add(m);
                    cmbTeklifMalzeme.Items.Add(m);
                }
            }
        }

        private void MalzemeleriKaydet()
        {
            var satirlar = new List<string>();
            // Malzeme listesini dosyaya yazdırıyor.
            foreach (Malzeme m in MalzemeListesi)
                satirlar.Add($"{m.MalzemeAdi}|{m.MalzemeCinsi}|{m.Birimi}|{m.Fiyati}|{m.StokAdedi}|{m.TeminEdilenFirma}|{m.VsYerAlacak}");
            File.WriteAllLines(MalzemeDosyaYolu, satirlar);
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            if (!MalzemeFormKontrol()) return;

            Malzeme yeni = MalzemeFormOku();

            MalzemeListesi.Add(yeni);

            MalzemeleriKaydet();

            MalzemeleriYukle();

            MalzemeFormTemizle();
            MessageBox.Show("Malzeme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMalzemeSil_Click(object sender, EventArgs e)
        {
            if (lstMalzemeler.SelectedIndex == -1)
            { MessageBox.Show("Silmek için listeden malzeme seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show("Seçili malzeme silinecek. Emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            MalzemeListesi.Remove((Malzeme)lstMalzemeler.SelectedItem);
            MalzemeleriKaydet();

            MalzemeleriYukle();

            MalzemeFormTemizle();

            MessageBox.Show("Malzeme silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMalzemeGuncelle_Click(object sender, EventArgs e)
        {
            if (lstMalzemeler.SelectedIndex == -1)
            { MessageBox.Show("Güncellemek için listeden malzeme seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!MalzemeFormKontrol()) return;

            Malzeme secilen = (Malzeme)lstMalzemeler.SelectedItem;
            Malzeme guncellenen = MalzemeFormOku();
            int idx = MalzemeListesi.IndexOf(secilen);
            MalzemeListesi[idx] = guncellenen;

            MalzemeleriKaydet();
            MalzemeleriYukle();

            MalzemeFormTemizle();

            MessageBox.Show("Malzeme güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstMalzemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMalzemeler.SelectedIndex == -1) return;
            Malzeme m = (Malzeme)lstMalzemeler.SelectedItem;
            txtMalzemeAdi.Text = m.MalzemeAdi;

            txtMalzemeCinsi.Text = m.MalzemeCinsi;

            txtBirimi.Text = m.Birimi;
            txtFiyati.Text = m.Fiyati.ToString();

            txtStokAdedi.Text = m.StokAdedi.ToString();
            txtTeminFirma.Text = m.TeminEdilenFirma;
        }

        private void btnMalzemeAra_Click(object sender, EventArgs e)
        {
            string aranan = txtMalzemeAra.Text.Trim().ToLower();
            lstMalzemeler.Items.Clear();

            // Koddaki şartlara uygun bir şekilde malzemeleri filtreleyip listeye ekler.
            foreach (Malzeme m in MalzemeListesi)
            {
                if (string.IsNullOrEmpty(aranan)
                    || m.MalzemeAdi.ToLower().Contains(aranan)
                    || m.MalzemeCinsi.ToLower().Contains(aranan)
                    || m.TeminEdilenFirma.ToLower().Contains(aranan))
                {
                    lstMalzemeler.Items.Add(m);
                }
            }

            if (lstMalzemeler.Items.Count == 0)
                MessageBox.Show("Aranan kritere uygun malzeme bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMalzemeTemizle_Click(object sender, EventArgs e)
        {
            MalzemeFormTemizle();
            MalzemeleriYukle();
        }

        private bool MalzemeFormKontrol()
        {
            if (string.IsNullOrWhiteSpace(txtMalzemeAdi.Text))
            { MessageBox.Show("Malzeme Adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            double fiyat; int stok;
            if (!double.TryParse(txtFiyati.Text, out fiyat))
            { MessageBox.Show("Fiyat sayısal bir değer olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            if (!int.TryParse(txtStokAdedi.Text, out stok))
            { MessageBox.Show("Stok adedi tam sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        private Malzeme MalzemeFormOku()
        {
            return new Malzeme(
                txtMalzemeAdi.Text.Trim(),
                txtMalzemeCinsi.Text.Trim(),
                txtBirimi.Text.Trim(),
                Convert.ToDouble(txtFiyati.Text),
                Convert.ToInt32(txtStokAdedi.Text),
                txtTeminFirma.Text.Trim());
        }

        private void MalzemeFormTemizle()
        {
            txtMalzemeAdi.Clear();

            txtMalzemeCinsi.Clear();

            txtBirimi.Clear();
            txtFiyati.Clear();

            txtStokAdedi.Clear();
            txtTeminFirma.Clear();

            txtMalzemeAra.Clear();
            lstMalzemeler.ClearSelected();
        }

        private void TeklifleriYukle()
        {
            TeklifListesi.Clear();
            lstKayitliTeklifler.Items.Clear();

            if (!File.Exists(TeklifDosyaYolu)) return;

            // Kayıtlı teklifleri ve malzemeleri dosyadan okuyup sisteme aktarma yapar.
            foreach (string satir in File.ReadAllLines(TeklifDosyaYolu))
            {
                string[] p = satir.Split('|');
                if (p.Length < 3) continue;

                Teklif t = new Teklif(Convert.ToInt32(p[0]), p[1], p[2]);

                if (p.Length > 3 && !string.IsNullOrEmpty(p[3]))
                {
                    foreach (string kalemStr in p[3].Split(';'))
                    {
                        string[] kp = kalemStr.Split(',');
                        if (kp.Length == 2)
                        {
                            Malzeme bulunan = MalzemeListesi.Find(m => m.MalzemeAdi == kp[0]);
                            if (bulunan != null)
                                t.KullanilanMalzemeler.Add(new TeklifKalemi(bulunan, Convert.ToInt32(kp[1])));
                        }
                    }
                }

                TeklifListesi.Add(t);
                lstKayitliTeklifler.Items.Add(t);
            }
        }

        private void TeklifleriKaydet()
        {
            var satirlar = new List<string>();
            // Listelerdeki teklifleri dosyaya yazmaya hazırlar.
            foreach (Teklif t in TeklifListesi)
            {
                string malzemeler = "";
                foreach (TeklifKalemi k in t.KullanilanMalzemeler)
                    malzemeler += $"{k.SecilenMalzeme.MalzemeAdi},{k.Adet};";

                satirlar.Add($"{t.TeklifNo}|{t.FirmaAdi}|{t.ProjeAdi}|{malzemeler}");
            }
            File.WriteAllLines(TeklifDosyaYolu, satirlar);
        }

        private void btnTeklifeMalzemeEkle_Click(object sender, EventArgs e)
        {
            if (cmbTeklifMalzeme.SelectedIndex == -1)
            { MessageBox.Show("Lütfen eklenecek malzemeyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int adet = (int)numAdet.Value;

            if (adet <= 0)
            { MessageBox.Show("Geçerli bir adet girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            Malzeme secilen = (Malzeme)cmbTeklifMalzeme.SelectedItem;

            if (adet > secilen.StokAdedi)
            { MessageBox.Show($"Yeterli stok yok! Mevcut: {secilen.StokAdedi} {secilen.Birimi}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            TeklifKalemi kalem = new TeklifKalemi(secilen, adet);

            GuncelTeklif.KullanilanMalzemeler.Add(kalem);

            lstTeklifKalemleri.Items.Add(kalem);
            lblToplamFiyat.Text = "Toplam: (hesaplanmadı)";
        }

        private void btnMalzemeKalemiCikar_Click(object sender, EventArgs e)
        {
            if (lstTeklifKalemleri.SelectedIndex == -1)
            { MessageBox.Show("Çıkarmak için listeden malzeme seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            TeklifKalemi kalem = (TeklifKalemi)lstTeklifKalemleri.SelectedItem;

            GuncelTeklif.KullanilanMalzemeler.Remove(kalem);
            lstTeklifKalemleri.Items.Remove(kalem);

            lblToplamFiyat.Text = "Toplam: (hesaplanmadı)";
        }

        private void btnFiyatHesapla_Click(object sender, EventArgs e)
        {
            if (GuncelTeklif.KullanilanMalzemeler.Count == 0)
            { MessageBox.Show("Teklifte malzeme yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            double toplam = GuncelTeklif.ToplamFiyatHesapla();
            lblToplamFiyat.Text = $"Toplam: {toplam:F2} TL";
        }

        private void btnTeklifKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTeklifNo.Text) ||
                string.IsNullOrWhiteSpace(txtTeklifFirma.Text) ||
                string.IsNullOrWhiteSpace(txtProjeAdi.Text))
            { MessageBox.Show("Teklif No, Firma ve Proje Adı zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            int teklifNo;
            if (!int.TryParse(txtTeklifNo.Text, out teklifNo))
            { MessageBox.Show("Teklif No tam sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (GuncelTeklif.KullanilanMalzemeler.Count == 0)
            { MessageBox.Show("Teklife en az bir malzeme eklemelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            GuncelTeklif.TeklifNo = teklifNo;

            GuncelTeklif.FirmaAdi = txtTeklifFirma.Text.Trim();
            GuncelTeklif.ProjeAdi = txtProjeAdi.Text.Trim();

            TeklifListesi.Add(GuncelTeklif);
            TeklifleriKaydet();

            TeklifleriYukle();

            GuncelTeklif = new Teklif();
            lstTeklifKalemleri.Items.Clear();
            txtTeklifNo.Clear();

            txtTeklifFirma.Clear();

            txtProjeAdi.Clear();
            lblToplamFiyat.Text = "Toplam: 0,00 TL";

            MessageBox.Show("Teklif başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTeklifSil_Click(object sender, EventArgs e)
        {
            if (lstKayitliTeklifler.SelectedIndex == -1)
            { MessageBox.Show("Silmek için listeden teklif seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show("Seçili teklif silinecek. Emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            TeklifListesi.Remove((Teklif)lstKayitliTeklifler.SelectedItem);
            TeklifleriKaydet();
            TeklifleriYukle();
            MessageBox.Show("Teklif silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTeklifAra_Click(object sender, EventArgs e)
        {
            string aranan = txtTeklifAra.Text.Trim().ToLower();
            lstKayitliTeklifler.Items.Clear();

            // Arama kriterine uyan teklifleri filtreleyip listeye ekler.
            foreach (Teklif t in TeklifListesi)
            {
                if (string.IsNullOrEmpty(aranan)
                    || t.FirmaAdi.ToLower().Contains(aranan)
                    || t.ProjeAdi.ToLower().Contains(aranan)
                    || t.TeklifNo.ToString().Contains(aranan))
                {
                    lstKayitliTeklifler.Items.Add(t);
                }
            }

            if (lstKayitliTeklifler.Items.Count == 0)
                MessageBox.Show("Aranan kritere uygun teklif bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            if (TeklifListesi.Count == 0)
            { MessageBox.Show("Kayıtlı teklif bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            string rapor = "===== TEKLİF RAPORU =====\r\n\r\n";

            // Kayıtlı tekliflerin detaylarını ve tutarlarını raporda birleştirir.
            foreach (Teklif t in TeklifListesi)
            {
                rapor += $"Teklif No: {t.TeklifNo}\r\n";
                rapor += $"Firma: {t.FirmaAdi}\r\n";
                rapor += $"Proje: {t.ProjeAdi}\r\n";
                rapor += "Malzemeler:\r\n";

                foreach (TeklifKalemi k in t.KullanilanMalzemeler)
                    rapor += $"  - {k}\r\n";

                rapor += $"TOPLAM: {t.ToplamFiyatHesapla():F2} TL\r\n";

                rapor += "------------------------\r\n";
            }

            MessageBox.Show(rapor, "Teklif Raporu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblAdet_Click(object sender, EventArgs e)
        {
        }

        private void lblBirimi_Click(object sender, EventArgs e)
        {
        }

        private void tabTeklif_Click(object sender, EventArgs e)
        {
        }

        private void txtTeklifFirma_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblProjeAdi_Click(object sender, EventArgs e)
        {
        }
    }
}