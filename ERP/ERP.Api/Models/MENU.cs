//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MENU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MENU()
        {
            this.MENU1 = new HashSet<MENU>();
            this.MENU_USER = new HashSet<MENU_USER>();
        }
    
        public string MA_MENU { get; set; }
        public string TEN_MENU { get; set; }
        public string LINK { get; set; }
        public string MENU_CHA { get; set; }
        public string MUC_TRUC_THUOC { get; set; }
    
        public virtual CCTC_MO_HINH_CONG_TY CCTC_MO_HINH_CONG_TY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MENU> MENU1 { get; set; }
        public virtual MENU MENU2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MENU_USER> MENU_USER { get; set; }
    }
}