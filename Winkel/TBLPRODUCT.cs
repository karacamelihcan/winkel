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
    
    public partial class TBLPRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLPRODUCT()
        {
            this.TBLSALES = new HashSet<TBLSALES>();
        }
    
        public short PRODUCTID { get; set; }
        public Nullable<byte> CATEGORYID { get; set; }
        public string PRODUCTCODE { get; set; }
        public string PRODUCTNAME { get; set; }
        public Nullable<short> PRODUCTVOLUME { get; set; }
        public Nullable<byte> UNITID { get; set; }
        public Nullable<short> SELLERID { get; set; }
        public Nullable<short> STOCKNUMBER { get; set; }
        public Nullable<decimal> PRICE { get; set; }
        public string PHOTO { get; set; }
        public Nullable<bool> STATUSID { get; set; }
        public Nullable<bool> STOCKID { get; set; }
    
        public virtual CATEGORY CATEGORY { get; set; }
        public virtual TBLSELLER TBLSELLER { get; set; }
        public virtual TBLSTATUS TBLSTATUS { get; set; }
        public virtual TBLSTOCKSTATUS TBLSTOCKSTATUS { get; set; }
        public virtual TBLUNIT TBLUNIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSALES> TBLSALES { get; set; }
    }
}