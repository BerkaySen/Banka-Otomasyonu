//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankaOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class HesapTbl
    {
        public int HesapId { get; set; }
        public int MusteriNo { get; set; }
        public string HesapNo { get; set; }
        public string IbanNo { get; set; }
        public int HesapBakiye { get; set; }
    
        public virtual KullaniciTbl KullaniciTbl { get; set; }
    }
}
