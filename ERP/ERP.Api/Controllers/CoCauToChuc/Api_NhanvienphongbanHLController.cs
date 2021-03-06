﻿
using ERP.Api.Models;
using ERP.Api.Models.NewModel.CongTy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ERP.Api.Controllers.CoCauToChuc
{
    public class Api_NhanvienphongbanHLController : ApiController
    {
        private ERP_DATABASEEntities db = new ERP_DATABASEEntities();

        // GET: api/Api_Nhanvienphongban/5
        public List<NguoiDungPhongBan> GetListNhanvien(string id)
        {
            var vData = (from t1 in db.CCTC_NHAN_VIEN
                         join t2 in db.HT_NGUOI_DUNG on t1.USERNAME equals t2.USERNAME
                         where t1.MA_PHONG_BAN == id

                         select new { t1.GIOI_TINH, t1.NGAY_SINH,t1.CHUC_VU, t1.QUE_QUAN,t1.THANH_TICH_CONG_TAC, t1.TRINH_DO_HOC_VAN, t2.HO_VA_TEN, t2.EMAIL, t2.SDT,t2.AVATAR });


            var result = vData.ToList().Select(x => new NguoiDungPhongBan()
            {
                HO_VA_TEN = x.HO_VA_TEN,
                EMAIL = x.EMAIL,
                CHUC_VU = x.CHUC_VU,
                SDT = x.SDT,
                GIOI_TINH = x.GIOI_TINH,
                NGAY_SINH = x.NGAY_SINH.ToString(),
                QUE_QUAN = x.QUE_QUAN,
                THANH_TICH_CONG_TAC = x.THANH_TICH_CONG_TAC,
                TRINH_DO_HOC_VAN = x.TRINH_DO_HOC_VAN,
                AVATAR = x.AVATAR
            }).ToList();
            return result;
        }
    }
}
