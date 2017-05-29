app.service('XuLyHoiGiaService', function ($http) {
    this.get_xulyhoigia = function (data) {
        return $http.get('http://27.72.144.148:8003/api/Api_XuLyYeuCauHoiGia/GetMH_XL_YEU_CAU_HOI_GIA', data).then(function (response) {
            return response.data;
        });
    };

    this.load_xulyhoigia = function (idYCHG) {
        return $http.post('http://27.72.144.148:8003/api/Api_LoadXuLyYeuCauHoiGia/Load_XL_HOIGIA/', idYCHG).then(function (response) {
            return response.data;
        });
    };

    this.save_stt = function (id,status) {
        return $http.put('http://27.72.144.148:8003/api/Api_XuLyYeuCauHoiGia/PutMH_YEU_CAU_HOI_GIA/' + id, status);
    };
});