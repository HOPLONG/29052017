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
    
    public partial class HT_THONG_BAO_MARKETING
    {
        public int ID { get; set; }
        public System.DateTime NGAY_THONG_BAO { get; set; }
        public string MA_PHONG_BAN { get; set; }
        public string NGUOI_THONG_BAO { get; set; }
        public string NOI_DUNG { get; set; }
    
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN { get; set; }
        public virtual CCTC_PHONG_BAN CCTC_PHONG_BAN { get; set; }
    }
}
