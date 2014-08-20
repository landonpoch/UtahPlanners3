'use strict';
app.controller('indexController', ['$scope',
    '$location',
    'authService',
    function ($scope, $location, authService) {
        $scope.logout = function () {
            authService.logout();
            $location.path('/home');
        };

        $scope.authentication = authService.authentication;
    }]);