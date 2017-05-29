app.controller('DonHangDaGiuCtrl', function ($scope, $http) {
    var username = $('#username').val();
    var isadmin = $('#isadmin').val();

    $http.post('http://27.72.144.148:8003/api/Api_DonHangDaGiu/ListDonHangDaGiuChuaBan/' + isadmin + '/' + username).then(function (response) {
        $scope.list_donhangdagiuchuaban = response.data;
    });

    $http.post('http://27.72.144.148:8003/api/Api_DonHangDaGiu/ListDonHangDaGiu/' + isadmin + '/' + username).then(function (response) {
        $scope.list_donhangdagiu = response.data;
    });

    $scope.get_thongtinchungPO = function (item) {
        $scope.item = item;
        $http.post('http://27.72.144.148:8003/api/Api_DonHangPO/PrintDonPO/' + $scope.item.MA_SO_PO).then(function (response) {
            $scope.thongtinbaogia = response.data;
            $scope.thongtinchung = $scope.thongtinbaogia.ChungPO;
            $scope.thongtinchitiet = $scope.thongtinbaogia.ChiTietPO;
        });
    };

    $scope.FixThisPO = function () {
        window.location.href = '/KinhDoanh/DonHangPO/Edit/' + $scope.item.MA_SO_PO;
    };
});