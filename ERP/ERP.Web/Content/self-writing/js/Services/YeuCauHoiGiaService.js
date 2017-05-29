app.service('YeuCauHoiGiaService', function ($http) {
    this.get_yeucau = function () {
        return $http.get('http://27.72.144.148:8003/api/Api_YeuCauHoiGia/GetMH_YEU_CAU_HOI_GIA').then(function (response) {
            return response.data;
        });
    };

});