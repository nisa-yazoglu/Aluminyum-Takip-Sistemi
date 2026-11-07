using System;
using System.Collections.Generic;

namespace AluminyumTakipSistemi
{
    public class TeklifKalemi
    {
        public Malzeme SecilenMalzeme { get; set; }
        public int Adet { get; set; }

        public TeklifKalemi(Malzeme secilenMalzeme, int adet)
        {
            SecilenMalzeme = secilenMalzeme;
            Adet = adet;
        }

        public double KalemTutariniHesapla()
        {
            return SecilenMalzeme.Fiyati * Adet;
        }

        public override string ToString()
        {
            return $"{SecilenMalzeme.MalzemeAdi} - {Adet} {SecilenMalzeme.Birimi} " +
            $"(Toplam: {KalemTutariniHesapla():F2} TL)";
        }
    }

    public class Teklif
    {
        public int TeklifNo { get; set; }
        public string FirmaAdi { get; set; }

        public string ProjeAdi { get; set; }

        public List<TeklifKalemi> KullanilanMalzemeler { get; set; }

        public Teklif()
        {
            KullanilanMalzemeler = new List<TeklifKalemi>();
        }

        public Teklif(int teklifNo, string firmaAdi, string projeAdi)
        {
            TeklifNo = teklifNo;
            FirmaAdi = firmaAdi;
            ProjeAdi = projeAdi;
            KullanilanMalzemeler = new List<TeklifKalemi>();
        }

        public double ToplamFiyatHesapla()
        {
            double toplamTutar = 0;

            // Teklifteki malzemelerin fiyatlarını toplayıp genel tutarı bulur.
            foreach (TeklifKalemi kalem in KullanilanMalzemeler)
            {
                toplamTutar += kalem.KalemTutariniHesapla();
            }
            return toplamTutar;
        }

        public override string ToString()
        {
            return $"No: {TeklifNo} | {FirmaAdi} | {ProjeAdi} | Toplam: {ToplamFiyatHesapla():F2} TL";
        }
    }
}