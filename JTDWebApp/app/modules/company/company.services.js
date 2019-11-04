companyServices.$inject = ['$http'];

export function companyServices($http) {

    var api = window.location.origin + window.location.pathname + 'api/';
    var service = {};

    service.getCompanies = () => $http.get(api + 'Company/');

    return service;
}

export default angular.module('services.companyServices', [])
    .service('companyServices', companyServices).name;