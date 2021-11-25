using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    class DataClass
    {
        BankaOtomasyonEModel db = new BankaOtomasyonEModel();

        #region
        /// <summary>
        /// Giriş Ekranında Girilen Bilgiler Doğrultusunda Bilgiler Doğrumu Değilmi Diye Veritabanından Kontrol Eder
        /// Eğer Kullanıcı Adı Ve Şifre Veritabanında Bir Kayıt İle Eşleşirse True Eşleşen Kayıt Yoksa False Döndürür
        /// </summary>
        /// <param name="kAdi"></param>
        /// <param name="kSifre"></param>
        /// <returns></returns>
        public bool kullanicidogrula(string kAdi, string kSifre)
        {
            var sorgu = from p in db.KullaniciTbls where p.KullaniciAd == kAdi && p.Sifre == kSifre select p;
            
            if (sorgu.Any())
            {

                return true;
            }

            else
            {
                return false;
            }

        }
        #endregion
        public int RolKontrol(string KullAd)
        {
            var sorgu = from p in db.KullaniciTbls where p.KullaniciAd == KullAd select p.RolId;
            return sorgu.First();
        }


        /// <summary>
        /// Web Service üzerinden verilen bilgiler doğrultusunda biri olup olmadıgını kontrol ediyor.
        /// Eğer Verilen bilgilerde birisi varsa true yoksa false degeri döndürüyor.
        /// </summary>
        /// <param name="TcNo"></param>
        /// <param name="Ad"></param>
        /// <param name="Soyad"></param>
        /// <param name="DogumYil"></param>
        /// <returns></returns>
        public bool TcKontrol(String TcNo,String Ad,String Soyad, int DogumYil)
        {
            long tcKimlik = long.Parse(TcNo);
            bool? sonuc;

            try
            {
                TcNoCheck.KPSPublicSoapClient webService = new TcNoCheck.KPSPublicSoapClient();
                sonuc = webService.TCKimlikNoDogrula(tcKimlik, Ad.ToUpper(), Soyad.ToUpper(), DogumYil);
            }
            catch (Exception)
            {
                sonuc = null;
            }

            if (sonuc == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        /// <summary>
        /// Veritabanında bulunan rollertbl de bulunan tüm rolleri geriye döndüren metoddur.
        /// </summary>
        /// <returns></returns>
        public List<string> TumRolleriGetir()
        {
            List<string> Roller = new List<string>();
            var sorgu = from p in db.RolTbls select p.RolAdi;
            foreach (var RolAdi in sorgu)
            {
                Roller.Add(RolAdi.ToString());
            }
            return Roller;
        }
        public List<string> TumKategorileriGetir()
        {
            List<string> Kategoriler = new List<string>();
            var sorgu = from p in db.HarcamaKategoriTbls select p.KategoriAdi;
            foreach (var kategori in sorgu)
            {
                Kategoriler.Add(kategori.ToString());
            }
            return Kategoriler;
        }
        public void KullaniciKayit(String KullAdi,String Sifre,String Statu,String TcNo,String Isım,String Soyisim,String DogumTarih)
        {
            KullaniciTbl YeniKayit = new KullaniciTbl(); //Tablo örneğini aldık.
            YeniKayit.KullaniciAd = KullAdi; //TAblo alanlarını dolduruyoruz.
            YeniKayit.Isım = Isım;
            YeniKayit.Soyisim = Soyisim;
            YeniKayit.Sifre = Sifre;
            YeniKayit.RolId = RolNameToRolId(Statu);
            YeniKayit.TcNo = TcNo;
            YeniKayit.DogumTarih = DogumTarih;
            db.KullaniciTbls.Add(YeniKayit);// Oluşturduğumuz model örneğinin Add Methodu ile YeniKayıt isimli örneği Kullanici tablosuna ekliyoruz.
            db.SaveChanges(); //Yine modelin. SaveChanges() ( DeğişiklikleriKaydet ) Methodu ile değişiklikleri kaydediyoruz.
        }

        private int RolNameToRolId(string RolAdi)
        {
            var sorgu = from p in db.RolTbls where p.RolAdi == RolAdi select p.RolId;
            return sorgu.First();
        }

        /// <summary>
        /// Tc kimliğe Göre Kullanıcı bulunursa bilgilerini dizi halinde döndürür.
        /// eğer kayıt bulunamazsa geriye boş bir dizi döndürür.
        /// </summary>
        /// <param name="TcKimlikNo"></param>
        /// <returns></returns>
        public string[] KullaniciProfilDondur(string TcKimlikNo)
        {
            string[] ProfilData = new string[4];
            var sorgu = (from p in db.KullaniciTbls where p.TcNo == TcKimlikNo select p).ToList();
            ProfilData[0] = sorgu[0].TcNo;
            ProfilData[1] = sorgu[0].Isım;
            ProfilData[2] = sorgu[0].Soyisim;
            ProfilData[3] = sorgu[0].DogumTarih;
            return ProfilData;
        }
        public string[] MusteriProfilDondur(string KullaniciAdi)
        {
            string[] ProfilData = new string[4];
            var sorgu = (from p in db.KullaniciTbls where p.KullaniciAd == KullaniciAdi select p).ToList();
            ProfilData[0] = sorgu[0].TcNo;
            ProfilData[1] = sorgu[0].Isım;
            ProfilData[2] = sorgu[0].Soyisim;
            ProfilData[3] = sorgu[0].DogumTarih;
            return ProfilData;
        }

        public string MusteriNoGetir(string TcNo)
        {
            var sorgu = from p in db.KullaniciTbls where p.TcNo == TcNo select p.KullaniciId;
            return sorgu.First().ToString();
        }
        
        /// <summary>
        /// Veritabanında Aynı Iban numarasaından daha önce varmı onu kontrol ediyor
        /// daha once aynı ıban numarası oluşturulmuşsa false döndürür eger önceden böyle bir iban no kayıtlı değilse true degeri dondurur.
        /// </summary>
        /// <param name="IbanNo"></param>
        /// <returns></returns>
        public bool IbanKontrol(string IbanNo)
        {
            try
            {
                var sorgu = from p in db.HesapTbls where p.IbanNo == IbanNo select p.IbanNo;

                if (sorgu.First().ToString() != null || sorgu.First().ToString() != "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
            catch (Exception)
            {
                return true;
            }
        }
        /// <summary>
        /// Veritabanında Aynı Hesapno numarasaından daha önce varmı onu kontrol ediyor
        /// daha once aynı HesapNo numarası oluşturulmuşsa false döndürür eger önceden böyle bir Hesap no kayıtlı değilse true degeri dondurur.
        /// </summary>
        /// <param name="HesapNo"></param>
        /// <returns></returns>
        public bool HesapNoKontrol(string HesapNo)
        {
            try
            {
                var sorgu = from p in db.HesapTbls where p.HesapNo == HesapNo select p.HesapNo;

                if (sorgu.First().ToString() != null || sorgu.First().ToString() != "")
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception)
            {
                return true;
            }
        }
        public bool HesapOlustur(int MusteriNo, string HesapNo,string IbanNo)
        {
            try
            {
                HesapTbl YeniHesap = new HesapTbl(); //Tablo örneğini aldık.
                YeniHesap.MusteriNo = MusteriNo; //TAblo alanlarını dolduruyoruz.
                YeniHesap.HesapNo = HesapNo;
                YeniHesap.IbanNo = IbanNo;
                YeniHesap.HesapBakiye = 0;
                db.HesapTbls.Add(YeniHesap);// Oluşturduğumuz model örneğinin Add Methodu ile YeniHesap isimli örneği Hesaptbl tablosuna ekliyoruz.
                db.SaveChanges(); //Yine modelin. SaveChanges() ( DeğişiklikleriKaydet ) Methodu ile değişiklikleri kaydediyoruz.
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<string> MusteriTumHesaplariGetir(string TcNo)
        {
            int MustteriNo=int.Parse( MusteriNoGetir(TcNo.ToString()));

            List<string> Hesaplar = new List<string>();
            var sorgu = from p in db.HesapTbls where p.MusteriNo == MustteriNo select p.HesapNo;
            foreach (var HesapNo in sorgu)
            {
                Hesaplar.Add(HesapNo.ToString());
            }
            return Hesaplar;
        }

        /// <summary>
        /// Verilen Hesap numarasına ait bakiye ve ardından Iban No Bilgilerini Döndürür
        /// </summary>
        /// <param name="HesapNo"></param>
        /// <returns></returns>
        public string[] SecilenHesapNoDetay(string HesapNo)
        {
            string[] HesapData = new string[2];
            var sorgu = (from p in db.HesapTbls where p.HesapNo == HesapNo select p).First();
            HesapData[0] = sorgu.HesapBakiye.ToString();
            HesapData[1] = sorgu.IbanNo;
            return HesapData;
        }
        /// <summary>
        /// Verilen Hesapno ya Belirtilen tutar kadar ekleme yapar işlem başarılıysa geriye true başarısızsa false döndürür.
        /// </summary>
        /// <param name="HesapNo"></param>
        /// <param name="EklenecekTutar"></param>
        /// <returns></returns>
        public bool HesapTutarEkle(string HesapNo , int EklenecekTutar)
        {
            try
            {
                var result = db.HesapTbls.SingleOrDefault(h => h.HesapNo == HesapNo);
                if (result != null)
                {
                    result.HesapBakiye = result.HesapBakiye + EklenecekTutar;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        /// <summary>
        /// Hesapno su verilen Müşterinin Banka Hesabından Verilen Tutar Kadar Bakiye Azaltır.
        /// </summary>
        /// <param name="HesapNo"></param>
        /// <param name="TahsilEdilecekTutar"></param>
        /// <returns></returns>
        public bool HesapTutarTahsil(string HesapNo, int TahsilEdilecekTutar)
        {
            try
            {
                var result = db.HesapTbls.SingleOrDefault(h => h.HesapNo == HesapNo);
                if (result != null)
                {
                    result.HesapBakiye = result.HesapBakiye - TahsilEdilecekTutar;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool KrediHesapTutarTahsil(int KartNo, int TahsilEdilecekTutar)
        {
            try
            {
                var result = db.KrediKartiDetayTbls.SingleOrDefault(h => h.KartNo == KartNo);
                if (result != null)
                {
                    result.Bakiye = result.Bakiye - TahsilEdilecekTutar;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool KrediHesapTutarEkle(int KartNo, int EklenecekTutar)
        {
            try
            {
                var result = db.KrediKartiDetayTbls.SingleOrDefault(h => h.KartNo == KartNo);
                if (result != null)
                {
                    result.Bakiye = result.Bakiye + EklenecekTutar;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }


        /// <summary>
        /// Verilen Bilgiler Dahilinde KrediKartDetayTbl İçerisine Yeni Kredi Kartı Alanı Oluşturur
        /// İşlem Başarılıysa true Başarısızsa false deger döndürür.
        /// </summary>
        /// <param name="TcNo"></param>
        /// <param name="HesapKesTarih"></param>
        /// <param name="SonOdeme"></param>
        /// <param name="EkstreKesimTarih"></param>
        /// <returns></returns>
        public bool KrediKartOlustur(string TcNo,string HesapKesTarih,string SonOdeme,string EkstreKesimTarih)
        {
            try
            {
                int MusteriNo =int.Parse(MusteriNoGetir(TcNo));
                KrediKartiDetayTbl YeniKart = new KrediKartiDetayTbl(); //Tablo örneğini aldık.
                YeniKart.MusteriNo = MusteriNo; //TAblo alanlarını dolduruyoruz.
                YeniKart.HesapKesTarih = HesapKesTarih;
                YeniKart.SonOdeme = SonOdeme;
                YeniKart.EkstreTarih = EkstreKesimTarih;
                db.KrediKartiDetayTbls.Add(YeniKart);// Oluşturduğumuz model örneğinin Add Methodu ile YeniHesap isimli örneği Hesaptbl tablosuna ekliyoruz.
                db.SaveChanges(); //Yine modelin. SaveChanges() ( DeğişiklikleriKaydet ) Methodu ile değişiklikleri kaydediyoruz.
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<string> MusteriKartlariTumu(string TcNo)
        {
            int MustteriNo = int.Parse(MusteriNoGetir(TcNo.ToString()));

            List<string> Kartlar = new List<string>();
            var sorgu = from p in db.KrediKartiDetayTbls where p.MusteriNo == MustteriNo select p.KartNo;
            foreach (var HesapNo in sorgu)
            {
                Kartlar.Add(HesapNo.ToString());
            }
            return Kartlar;
        }
        public string[] SecilenKartDetay(int KartNo)
        {
            string[] HesapData = new string[2];
            var sorgu = (from p in db.KrediKartiDetayTbls where p.KartNo == KartNo select p).First();
            HesapData[0] = sorgu.Bakiye.ToString();
            HesapData[1] = sorgu.KartNo.ToString();
            return HesapData;
        }
        public int KrediKartBakiye(int KartNo)
        {
            var sorgu = from p in db.KrediKartiDetayTbls where p.KartNo == KartNo select p.Bakiye;
            return int.Parse(sorgu.First().ToString());
        }

        /// <summary>
        /// Alışveriş yapıldıgında girilen bilgileri alışverişlerin detaylı halde tutuldugu tabloya ekler
        /// işlem başarılıysa true başarısızsa false doner
        /// </summary>
        /// <param name="KartId"></param>
        /// <param name="KategoriName"></param>
        /// <param name="HarcamaTutar"></param>
        /// <param name="IslemTarihi"></param>
        /// <returns></returns>
        public bool AlisverisDetayOlustur(int KartId,string KategoriName,int HarcamaTutar)
        {
            try
            {//YYYY-MM-DD hh:mm:ss[.nnn]  veritabanı kayıt format*/
                var sorgu = from p in db.HarcamaKategoriTbls where p.KategoriAdi == KategoriName select p.KategoriId;
            string date = DateTime.Now.ToString();
                KrediHarcamaDetayTbl YeniHarcama = new KrediHarcamaDetayTbl(); //Tablo örneğini aldık.
                YeniHarcama.HarcamaTutar = HarcamaTutar;
                YeniHarcama.HarcamaKategoriId =sorgu.First();
                YeniHarcama.KartId = KartId;
                YeniHarcama.IslemTarih = date;
                db.KrediHarcamaDetayTbls.Add(YeniHarcama);
                db.SaveChanges(); 
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int KrediKartEkstreTarihGetir(int Kartno)
        {
            var sorgu = from p in db.KrediKartiDetayTbls where p.KartNo == Kartno select p.EkstreTarih;
            return int.Parse(sorgu.First().ToString());
        }

        public List<KrediHarcamaDetayTbl> KartEkstreDondur(int KartNo)
        {
            var sorgu = (from p in db.KrediHarcamaDetayTbls where p.KartId == KartNo select p).ToList();
            return sorgu;
        }

        public void HesapTutarDetayEkle(string HesapNo, int Tutar,string IslemTip)
        {
            var sorgu = from p in db.HesapIslemDetays where p.HesapNo == HesapNo select p.HesapNo;
            string date = DateTime.Now.ToString();
            HesapIslemDetay YeniIslem = new HesapIslemDetay(); //Tablo örneğini aldık.
            YeniIslem.HesapNo = HesapNo;
            YeniIslem.IslemTur = IslemTip;
            YeniIslem.Tutar = Tutar.ToString();
            YeniIslem.IslemTarih = date;
            db.HesapIslemDetays.Add(YeniIslem);
            db.SaveChanges();

        }

        public List<HesapIslemDetay> HesapIslemDondur(string HesapNo)
        {
            string[] ProfilData = new string[4];
            var sorgu = (from p in db.HesapIslemDetays where p.HesapNo == HesapNo select p);
            return sorgu.ToList();
        }
        public List<HesapTbl> HesapNoDetayTumu(string HesapNo)
        {
            
            var sorgu = (from p in db.HesapTbls where p.HesapNo == HesapNo select p);
            return sorgu.ToList();
        }
        public string[] MusteriNoDetay(int MusteriNo)
        {
            string[] ProfilData = new string[4];
            var sorgu = (from p in db.KullaniciTbls where p.KullaniciId == MusteriNo select p).First();
            ProfilData[0] = sorgu.Isım;
            ProfilData[1] = sorgu.Soyisim;
            ProfilData[2] = sorgu.DogumTarih;
            return ProfilData;
        }
        /// <summary>
        ///  Veritabanında Aynı Tcno numarasaından daha önce varmı onu kontrol ediyor
        /// daha once aynı Tc numarası oluşturulmuşsa false döndürür eger önceden böyle bir Tc no kayıtlı değilse true degeri dondurur.
        /// </summary>
        /// <param name="TcNo"></param>
        /// <returns></returns>
        public bool TcNoKayitKontrol(string TcNo)
        {
            try
            {
                var sorgu = from p in db.KullaniciTbls where p.TcNo == TcNo select p.TcNo;

                if (sorgu.First().ToString() != null || sorgu.First().ToString() != "")
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
