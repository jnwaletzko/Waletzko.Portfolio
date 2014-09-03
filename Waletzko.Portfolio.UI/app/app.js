angular.module('PortfolioApp', [
    'ngResource',
    'ngRoute'])
.config(['$routeProvider', function($routeProvider) {
    $routeProvider
        .when('/portfoliodetails',
            {
                controller: 'PortfolioDetailsController',
                templateUrl: ''
            })
        .otherwise({ redirectTo: '/'})
}]);