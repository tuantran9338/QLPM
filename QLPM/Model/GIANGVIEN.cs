//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLPM.Models
{
    using QLPM.Model;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class GIANGVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIANGVIEN()
        {
            this.DANGKYTIETHOCs = new HashSet<DANGKYTIETHOC>();
        }
        [Key]
        public string MAGV { get; set; }
        public string TEN { get; set; }
        public string EMAIL { get; set; }
        public string SDT { get; set; }
        public string MAQH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANGKYTIETHOC> DANGKYTIETHOCs { get; set; }
        public virtual QUYENHAN QUYENHAN { get; set; }
    }
}
