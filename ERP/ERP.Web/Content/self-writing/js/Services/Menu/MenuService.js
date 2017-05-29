app.service('menuService', function ($http) {
    this.get_menu = function (username) {
        return $http.get('http://27.72.144.148:8003/api/Api_ListMenu/' + username).then(function (response) {
            return response.data;
        });
    };

    this.save_menu = function (maphongban, username, mamenu, data_save) {
        return $http.put('http://27.72.144.148:8003/api/Api_MENU_USER/' + maphongban + '/' + username + '/' + mamenu, data_save);
    }

    this.get_menucha = function (username, menucha) {
        return $http.get('http://27.72.144.148:8003/api/Api_ListMenu/' + username + '/' + menucha).then(function (response) {
            return response.data;
        });
    }

    this.get_listmenucha = function (username, menucha) {
        return $http.get('http://27.72.144.148:8003/api/Api_ListMenuCha/' + username + '/' + menucha).then(function (response) {
            return response.data;
        });
    }
});