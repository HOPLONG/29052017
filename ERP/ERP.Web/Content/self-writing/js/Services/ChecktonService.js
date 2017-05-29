app.service('ChecktonService', function ($http) {
    this.get_dataton = function (sotrang) {
        return $http.get("http://27.72.144.148:8003/api/Api_Checktonkho/Get/" + sotrang).then(function (response) {
            return response.data;
        });
    }
});
