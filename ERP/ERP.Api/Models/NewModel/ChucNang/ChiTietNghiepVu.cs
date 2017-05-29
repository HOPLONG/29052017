using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP.Api.Models.NewModel.ChucNang
{
    public class ChiTietNghiepVu
    {
        public string TEN_CHI_TIET { set; get; }
        public string ID_NGHIEP_VU { set; get; }
        public string MO_TA { set; get; }
        public string TEN_NGHIEP_VU { set; get; }
        public int ID { get; set; }
    }
}