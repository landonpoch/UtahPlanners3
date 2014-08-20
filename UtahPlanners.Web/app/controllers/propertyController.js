app.controller('propertyController', ['$scope', 'propertyService', function ($scope, propertyService) {
    $scope.properties = [];

    propertyService.getProperties().then(function (results) {
        $scope.properties = results.data;
    }, function (err) {
        // alert(err.data.message):
    });
}]);