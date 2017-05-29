app.service('KhachChuaGiaoDichService', function ($http) {
    this.get_dskhachchuagiaodich = function (username) {
        return $http.get("http://27.72.144.148:8003/api/Api_DSKhachGiaoDich/GetKHChuaPhatSinh/" + username).then(function (response) {
            return response.data;
        });
    }
});
