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
    
    public partial class DM_TAI_KHOAN_HACH_TOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_TAI_KHOAN_HACH_TOAN()
        {
            this.BH_CT_DON_BAN_HANG = new HashSet<BH_CT_DON_BAN_HANG>();
            this.BH_CT_DON_BAN_HANG1 = new HashSet<BH_CT_DON_BAN_HANG>();
            this.BH_CT_DON_BAN_HANG2 = new HashSet<BH_CT_DON_BAN_HANG>();
            this.DM_DINH_KHOAN_TU_DONG = new HashSet<DM_DINH_KHOAN_TU_DONG>();
            this.DM_DINH_KHOAN_TU_DONG1 = new HashSet<DM_DINH_KHOAN_TU_DONG>();
            this.DM_TAI_KHOAN_HACH_TOAN1 = new HashSet<DM_TAI_KHOAN_HACH_TOAN>();
            this.KHO_CT_NHAP_KHO = new HashSet<KHO_CT_NHAP_KHO>();
            this.KHO_CT_NHAP_KHO1 = new HashSet<KHO_CT_NHAP_KHO>();
            this.KHO_CT_NHAP_KHO2 = new HashSet<KHO_CT_NHAP_KHO>();
            this.KHO_CT_NHAP_KHO3 = new HashSet<KHO_CT_NHAP_KHO>();
            this.KHO_CT_XUAT_KHO = new HashSet<KHO_CT_XUAT_KHO>();
            this.KHO_CT_XUAT_KHO1 = new HashSet<KHO_CT_XUAT_KHO>();
            this.KHO_CT_XUAT_KHO2 = new HashSet<KHO_CT_XUAT_KHO>();
            this.KT_SO_NHAT_KY_CHUNG = new HashSet<KT_SO_NHAT_KY_CHUNG>();
            this.KT_SO_NHAT_KY_CHUNG1 = new HashSet<KT_SO_NHAT_KY_CHUNG>();
            this.MH_CT_DE_NGHI_NHAP_KHO = new HashSet<MH_CT_DE_NGHI_NHAP_KHO>();
            this.MH_CT_DE_NGHI_NHAP_KHO1 = new HashSet<MH_CT_DE_NGHI_NHAP_KHO>();
            this.MH_CT_DE_NGHI_NHAP_KHO2 = new HashSet<MH_CT_DE_NGHI_NHAP_KHO>();
            this.MH_CT_MDV = new HashSet<MH_CT_MDV>();
            this.MH_CT_MDV1 = new HashSet<MH_CT_MDV>();
            this.MH_CT_MDV2 = new HashSet<MH_CT_MDV>();
            this.NH_CHUYEN_TIEN_NOI_BO = new HashSet<NH_CHUYEN_TIEN_NOI_BO>();
            this.NH_CT_NTTK = new HashSet<NH_CT_NTTK>();
            this.NH_CT_UNC = new HashSet<NH_CT_UNC>();
            this.NH_CHUYEN_TIEN_NOI_BO1 = new HashSet<NH_CHUYEN_TIEN_NOI_BO>();
            this.NH_CT_NTTK1 = new HashSet<NH_CT_NTTK>();
            this.NH_CT_UNC1 = new HashSet<NH_CT_UNC>();
            this.QUY_CT_PHIEU_CHI = new HashSet<QUY_CT_PHIEU_CHI>();
            this.QUY_CT_PHIEU_THU = new HashSet<QUY_CT_PHIEU_THU>();
            this.QUY_CT_PHIEU_CHI1 = new HashSet<QUY_CT_PHIEU_CHI>();
            this.QUY_CT_PHIEU_THU1 = new HashSet<QUY_CT_PHIEU_THU>();
            this.QUY_CT_PHIEU_CHI2 = new HashSet<QUY_CT_PHIEU_CHI>();
            this.HHs = new HashSet<HH>();
            this.HHs1 = new HashSet<HH>();
            this.HHs2 = new HashSet<HH>();
        }
    
        public string SO_TK { get; set; }
        public string TEN_TK { get; set; }
        public string TINH_CHAT { get; set; }
        public string TEN_TA { get; set; }
        public string TK_CAP_CHA { get; set; }
        public string DIEN_GIAI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BH_CT_DON_BAN_HANG> BH_CT_DON_BAN_HANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BH_CT_DON_BAN_HANG> BH_CT_DON_BAN_HANG1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BH_CT_DON_BAN_HANG> BH_CT_DON_BAN_HANG2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_DINH_KHOAN_TU_DONG> DM_DINH_KHOAN_TU_DONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_DINH_KHOAN_TU_DONG> DM_DINH_KHOAN_TU_DONG1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_TAI_KHOAN_HACH_TOAN> DM_TAI_KHOAN_HACH_TOAN1 { get; set; }
        public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_NHAP_KHO> KHO_CT_NHAP_KHO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_NHAP_KHO> KHO_CT_NHAP_KHO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_NHAP_KHO> KHO_CT_NHAP_KHO2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_NHAP_KHO> KHO_CT_NHAP_KHO3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_XUAT_KHO> KHO_CT_XUAT_KHO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_XUAT_KHO> KHO_CT_XUAT_KHO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_XUAT_KHO> KHO_CT_XUAT_KHO2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KT_SO_NHAT_KY_CHUNG> KT_SO_NHAT_KY_CHUNG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KT_SO_NHAT_KY_CHUNG> KT_SO_NHAT_KY_CHUNG1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_CT_DE_NGHI_NHAP_KHO> MH_CT_DE_NGHI_NHAP_KHO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_CT_DE_NGHI_NHAP_KHO> MH_CT_DE_NGHI_NHAP_KHO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_CT_DE_NGHI_NHAP_KHO> MH_CT_DE_NGHI_NHAP_KHO2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_CT_MDV> MH_CT_MDV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_CT_MDV> MH_CT_MDV1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_CT_MDV> MH_CT_MDV2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NH_CHUYEN_TIEN_NOI_BO> NH_CHUYEN_TIEN_NOI_BO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NH_CT_NTTK> NH_CT_NTTK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NH_CT_UNC> NH_CT_UNC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NH_CHUYEN_TIEN_NOI_BO> NH_CHUYEN_TIEN_NOI_BO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NH_CT_NTTK> NH_CT_NTTK1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NH_CT_UNC> NH_CT_UNC1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUY_CT_PHIEU_CHI> QUY_CT_PHIEU_CHI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUY_CT_PHIEU_THU> QUY_CT_PHIEU_THU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUY_CT_PHIEU_CHI> QUY_CT_PHIEU_CHI1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUY_CT_PHIEU_THU> QUY_CT_PHIEU_THU1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUY_CT_PHIEU_CHI> QUY_CT_PHIEU_CHI2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HH> HHs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HH> HHs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HH> HHs2 { get; set; }
    }
}
