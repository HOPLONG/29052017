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
    
    public partial class MH_DE_NGHI_JOIN_PO_MH
    {
        public int ID { get; set; }
        public int ID_DE_NGHI { get; set; }
        public int ID_PO_DAT_HANG { get; set; }
        public int SL_VE { get; set; }
    
        public virtual MH_CT_DE_NGHI_NHAP_KHO MH_CT_DE_NGHI_NHAP_KHO { get; set; }
        public virtual MH_PO_CT_MUA_HANG MH_PO_CT_MUA_HANG { get; set; }
    }
}
