app.service('TonCacNoiService', function ($http) {
    this.get_dataton = function (machuan) {
        return $http.get("http://27.72.144.148:8003/api/Api_TonKhoHL/GetHH_TON_KHO/" + machuan + "/1").then(function (response) {
            return response.data;
        });
    }
});
