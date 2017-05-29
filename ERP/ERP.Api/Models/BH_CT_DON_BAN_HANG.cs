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
    
    public partial class BH_CT_DON_BAN_HANG
    {
        public int ID { get; set; }
        public string MA_SO_BH { get; set; }
        public string MA_HANG { get; set; }
        public string MA_DIEU_CHINH { get; set; }
        public string TK_NO { get; set; }
        public string TK_CO { get; set; }
        public string DVT { get; set; }
        public int SO_LUONG { get; set; }
        public decimal DON_GIA { get; set; }
        public decimal THANH_TIEN_HANG { get; set; }
        public string DIEN_GIAI_THUE { get; set; }
        public double THUE_GTGT { get; set; }
        public double TIEN_THUE_GTGT { get; set; }
        public string TK_THUE { get; set; }
        public double TIEN_THANH_TOAN { get; set; }
        public string MA_PO { get; set; }
    
        public virtual BH_DON_HANG_PO BH_DON_HANG_PO { get; set; }
        public virtual BH_DON_BAN_HANG BH_DON_BAN_HANG { get; set; }
        public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN { get; set; }
        public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN1 { get; set; }
        public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN2 { get; set; }
        public virtual HH HH { get; set; }
    }
}
