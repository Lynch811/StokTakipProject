//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicariOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_FIRMALAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_FIRMALAR()
        {
            this.TBL_BANKALAR = new HashSet<TBL_BANKALAR>();
        }
    
        public short ID { get; set; }
        public string AD { get; set; }
        public string YETKILISTATU { get; set; }
        public string YETKILIADSOYAD { get; set; }
        public string YETKILITC { get; set; }
        public string SEKTOR { get; set; }
        public string TELEFON1 { get; set; }
        public string TELEFON2 { get; set; }
        public string TELEFON3 { get; set; }
        public string MAIL { get; set; }
        public string FAX { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string VERGIDAIRE { get; set; }
        public string ADRES { get; set; }
        public string OZELKOD1 { get; set; }
        public string OZELKOD2 { get; set; }
        public string OZELKOD3 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_BANKALAR> TBL_BANKALAR { get; set; }
    }
}