//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Web.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class MH_HANG_CAN_DAT
    {
        public int ID { get; set; }
        public int ID_CT_PO { get; set; }
        public string MA_HANG { get; set; }
        public int SL_DAT { get; set; }
        public Nullable<System.DateTime> NGAY_XUAT { get; set; }
        public string NGUOI_GIU { get; set; }
        public bool DA_LEN_PO_MUA_HANG { get; set; }
    
        public virtual BH_CT_DON_HANG_PO BH_CT_DON_HANG_PO { get; set; }
        public virtual HH HH { get; set; }
        public virtual HT_NGUOI_DUNG HT_NGUOI_DUNG { get; set; }
    }
}
