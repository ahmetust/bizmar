//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Satış
{
    using System;
    using System.Collections.Generic;
    
    public partial class irsaliye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public irsaliye()
        {
            this.urun = new HashSet<urun>();
            this.urun1 = new HashSet<urun>();
        }
    
        public int irsaliyeNo { get; set; }
        public System.DateTime irsaliyeTarih { get; set; }
        public double irsaliyeTutar { get; set; }
        public Nullable<int> ulNo { get; set; }
        public Nullable<int> tNo { get; set; }
    
        public virtual tedarikci tedarikci { get; set; }
        public virtual tedarikci tedarikci1 { get; set; }
        public virtual urunListesi urunListesi { get; set; }
        public virtual urunListesi urunListesi1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<urun> urun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<urun> urun1 { get; set; }
    }
}
