app.service('TimKhachHangService', function ($http) {
    this.find_khachhang = function (sdt) {
        return $http.get("http://27.72.144.148:8003/api/TimKiemKhachHang/GetKH/" + sdt).then(function (response) {
            return response.data;
        });
    }
   
});