using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    class HesapOlusturClass
    {
        Random rnd = new Random();

        /// <summary>
        /// 12 karakterden oluşan string veri döndürür Rastgele Hesap Numarası Oluşturmuş Olur.
        /// </summary>
        /// <returns></returns>
        public string HesapNoUret()
        {
            
            string Hesapno=null;
            for (int i = 1; i <= 12; i++)
            {
                Hesapno += rnd.Next(0, 9).ToString();
            }
            return Hesapno;
        }
        /// <summary>
        /// 24 Karakterden Oluşan Rastgele Iban Stringi Oluşturur ve Geri Döndürür.
        /// </summary>
        /// <returns></returns>
        public string IbanNoOlustur()
        {
            string Iban = null;
            for (int i = 1; i < 24; i++)
            {
                Iban +=rnd.Next(0, 9).ToString();
            }
            return Iban;
            
        }
    }
}
