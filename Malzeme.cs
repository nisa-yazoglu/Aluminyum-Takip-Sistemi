using System;

namespace AluminyumTakipSistemi
{
    public class Malzeme
    {
        public string MalzemeAdi { get; set; }
        public string MalzemeCinsi { get; set; }

        public string Birimi { get; set; }
        public double Fiyati { get; set; }

        public int StokAdedi { get; set; }
        public string TeminEdilenFirma { get; set; }
        public string VsYerAlacak { get; set; }

        public Malzeme()
        {
            VsYerAlacak = "";
        }

        public Malzeme(string malzemeAdi, string malzemeCinsi, string birimi,
                       double fiyati, int stokAdedi, string teminEdilenFirma, string vsYerAlacak = "")
        {
            MalzemeAdi = malzemeAdi;
            MalzemeCinsi = malzemeCinsi;
            Birimi = birimi;
            Fiyati = fiyati;
            StokAdedi = stokAdedi;
            TeminEdilenFirma = teminEdilenFirma;
            VsYerAlacak = vsYerAlacak;
        }

        public override string ToString()
        {
            return $"{MalzemeAdi} - {MalzemeCinsi} (Stok: {StokAdedi} {Birimi} | {Fiyati:F2} TL/{Birimi})";
        }
    }
}