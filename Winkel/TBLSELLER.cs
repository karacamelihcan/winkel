//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Winkel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLSELLER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLSELLER()
        {
            this.TBLPRODUCT = new HashSet<TBLPRODUCT>();
            this.TBLSALES = new HashSet<TBLSALES>();
        }
    
        public short SELLERID { get; set; }
        public string SELLERNAME { get; set; }
        public string SELLERSURNAME { get; set; }
        public string SELLEREMAIL { get; set; }
        public string SELLERPASSWORD { get; set; }
        public Nullable<byte> SELLERCITY { get; set; }
        public string PHOTO { get; set; }
        public Nullable<bool> STATUSID { get; set; }
    
        public virtual TBLCITY TBLCITY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLPRODUCT> TBLPRODUCT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSALES> TBLSALES { get; set; }
        public virtual TBLSTATUS TBLSTATUS { get; set; }
    }
}
