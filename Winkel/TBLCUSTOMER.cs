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
    
    public partial class TBLCUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLCUSTOMER()
        {
            this.TBLSALES = new HashSet<TBLSALES>();
        }
    
        public short CUSTOMERID { get; set; }
        public string CUSTOMERNAME { get; set; }
        public string CUSTOMERSURNAME { get; set; }
        public string CUSTOMEREMAIL { get; set; }
        public string CUSTOMERPASSWORD { get; set; }
        public Nullable<byte> CUSTOMERCITY { get; set; }
        public string PHOTO { get; set; }
        public Nullable<bool> STATUSID { get; set; }
    
        public virtual TBLCITY TBLCITY { get; set; }
        public virtual TBLSTATUS TBLSTATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSALES> TBLSALES { get; set; }
    }
}
