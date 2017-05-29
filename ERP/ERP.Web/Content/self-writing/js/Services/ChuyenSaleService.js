app.service('chuyensaleService', function ($http) {
    this.get_listchuyensale = function (username) {
        return $http.get('http://27.72.144.148:8003/api/Api_ChuyenSale/KH_CHUYEN_SALES/' + username).then(function (response) {
            return response.data;
        });
    };

    this.save_listchuyensale = function (data_save) {
        return $http.post('http://27.72.144.148:8003/api/Api_ChuyenSale/XuLyChyenSale', data_save);
    };

    this.add_listchuyensale = function (data_add) {
        return $http.post('http://27.72.144.148:8003/api/Api_ChuyenSale', data_add);
    };
});