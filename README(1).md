# Alüminyum Takip Sistemi

Nesneye Dayalı Programlama dersi için yaptığım ödev. Alüminyum doğrama işinde kullanılan malzemelerin stok takibini yapan ve bu malzemelerle firmalara fiyat teklifi hazırlanabilen bir Windows Forms uygulaması. C# ile yazıldı.

## Neler yapılabiliyor

Malzeme sekmesinde malzeme eklenip güncellenebiliyor, silinebiliyor ve ada, cinse ya da tedarikçi firmaya göre aranabiliyor. Her malzemenin cinsi, birimi, birim fiyatı, stok adedi ve hangi firmadan alındığı tutuluyor.

Teklif sekmesinde listeden malzeme seçip adet girerek teklif oluşturuluyor. Girilen adet stoktan fazlaysa program uyarı veriyor. Toplam fiyat hesaplanıp teklif kaydedilebiliyor, kayıtlı teklifler aranabiliyor ve hepsi tek bir raporda görüntülenebiliyor.

Veriler veritabanı yerine programın klasöründeki `malzemeler.txt` ve `teklifler.txt` dosyalarında tutuluyor.

## Sınıflar

- `Malzeme`: bir malzemenin bilgileri
- `TeklifKalemi`: teklifteki bir malzeme ve adedi, kalem tutarını hesaplıyor
- `Teklif`: teklifin bilgileri ve kalemleri, toplam tutarı hesaplıyor
- `Form1`: arayüz, dosyaya kaydetme ve dosyadan okuma

## Çalıştırmak için

Visual Studio'da `AluminyumTakipSistemi.sln` dosyasını açıp çalıştırmak yeterli. Proje .NET Framework 4.7.2 kullanıyor.
