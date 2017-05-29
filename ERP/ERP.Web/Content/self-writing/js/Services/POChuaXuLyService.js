app.service('POChuaXuLyService', function ($http) {
    this.get_list_pochuaxuly = function (salequanly) {
        return $http.post('http://27.72.144.148:8003/api/Api_POChuaXuLy/ListPO_CHUA_XU_LY/' + salequanly).then(function (response) {
            return response.data;
        });
    };
});