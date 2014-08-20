'use strict';
app.factory('propertyService', ['$http', function ($http) {
    var serviceBase = 'http://localhost:55614/';
    var propertyServiceFactory = {};

    var _getProperties = function () {
        return $http.get(serviceBase + 'api/property')
            .then(function (results) {
                return results;
            });
    };

    propertyServiceFactory.getProperties = _getProperties;
    return propertyServiceFactory;
}]);