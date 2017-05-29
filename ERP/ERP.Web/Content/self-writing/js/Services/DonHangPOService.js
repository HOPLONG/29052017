app.service('DonHangPOService', function ($http) {
    this.get_danhsachPO = function (isadmin,username) {
        return $http.get("http://27.72.144.148:8003/api/Api_DonHangPO/GetBH_DON_HANG_PO/" + isadmin + '/' + username).then(function (response) {
            return response.data;
        });
    };

    this.get_thongtinchungPO = function (masoPO) {
        return $http.get("http://27.72.144.148:8003/api/Api_DonHangPO/GetThongtinChung/" + masoPO).then(function (response) {
            return response.data;
        });
    };

    this.get_thongtinchitietPO = function (masoPO) {
        return $http.post("http://27.72.144.148:8003/api/Api_ChiTiet_DonHangPO/ThongtinChitiet/" + masoPO).then(function (response) {
            return response.data;
        });
    };

    this.save_thongtinchungPO = function (masoPO,data_save) {
        return $http.put('http://27.72.144.148:8003/api/Api_DonHangPO/PutBH_DON_HANG_PO/' + masoPO, data_save);
    };

    this.delete_thongtinchungPO = function (masoPO) {
        return $http.delete('http://27.72.144.148:8003/api/Api_DonHangPO/DeleteBH_DON_HANG_PO/' + masoPO);
    };
});