(window["webpackJsonp"] = window["webpackJsonp"] || []).push([[4],{

/***/ "./app/modules/guest/guest-list.component.js":
/*!***************************************************!*\
  !*** ./app/modules/guest/guest-list.component.js ***!
  \***************************************************/
/*! exports provided: guestListComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "guestListComponent", function() { return guestListComponent; });
/* harmony import */ var angular__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! angular */ "./node_modules/angular/index.js");
/* harmony import */ var angular__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(angular__WEBPACK_IMPORTED_MODULE_0__);
﻿

const guestListComponent = {
    template: __webpack_require__(/*! ./guest-list.html */ "./app/modules/guest/guest-list.html"),
    controller: ['$scope', 'guestServices', ($scope, guestServices) => {
        $scope.hello = "Hello";

        // console.log(guestServices);

        $scope.teste = (t) => alert("Editando usuario: " + t);

        guestServices.getGuests()
            .success(r => $scope.guests = r);
    }]
};

/***/ }),

/***/ "./app/modules/guest/guest-list.html":
/*!*******************************************!*\
  !*** ./app/modules/guest/guest-list.html ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div\r\n    class=\"d-flex justify-content-between row flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3 border-bottom\">\r\n    <h3 class=\"col-sm-8 font-weight-light\">Clientes</h3>\r\n    <div class=\"btn-toolbar col-sm-4\">\r\n        <div class=\"btn-group btn-block\">\r\n            <button type=\"button\" class=\"sticky-top font-weight-light\r\n                       btn pmd-btn-outline btn-sm pmd-btn-raised\r\n                     btn-default\" ng-click=\"openModalCnpj()\">\r\n                Novo c/ CPF\r\n            </button>\r\n            <button type=\"button\" class=\"sticky-top font-weight-light\r\n                       btn pmd-btn-outline btn-sm pmd-btn-raised\r\n                     btn-default\" ng-click=\"openModalEdit()\">\r\n                Novo manual\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"table-responsive\">\r\n    <table class=\"table table-hover table-striped table-sm table-bordered\">\r\n        <thead class=\"thead-dark\">\r\n            <tr class=\"text-center\">\r\n                <th scope=\"col\">#</th>\r\n                <th scope=\"col\">Nome</th>\r\n                <th scope=\"col\">CPF</th>\r\n                <th scope=\"col\">Cidade</th>\r\n                <th scope=\"col\">Contato</th>\r\n                <th scope=\"col\">Telefone</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n            <tr ng-if=\"guests.length > 0\" ng-repeat=\"guest in guests\" class=\"text-center\">\r\n                <td scope=\"row\" ng-click=\"teste(guest.Name)\"><a href=\"#guests\">{{guest.Id}}</a></td>\r\n                <td>{{guest.Name}}</td>\r\n                <td>{{guest.Cpf}}</td>\r\n                <td>{{guest.City}}</td>\r\n                <td>{{guest.ContactName}}</td>\r\n                <td>{{guest.Phone}}</td>\r\n            </tr>\r\n            <tr>\r\n                <td ng-if=\"companies.length == 0\" class=\"text-center\" colspan=\"6\">Não existem dados...</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>";

/***/ }),

/***/ "./app/modules/guest/guest.module.js":
/*!*******************************************!*\
  !*** ./app/modules/guest/guest.module.js ***!
  \*******************************************/
/*! exports provided: GUEST_MODULE */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "GUEST_MODULE", function() { return GUEST_MODULE; });
/* harmony import */ var _guest_list_component__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./guest-list.component */ "./app/modules/guest/guest-list.component.js");
/* harmony import */ var _guest_services__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./guest.services */ "./app/modules/guest/guest.services.js");
/* harmony import */ var _guest_states__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./guest.states */ "./app/modules/guest/guest.states.js");
﻿





const GUEST_MODULE = angular.module('guest.module', []);

GUEST_MODULE.service('guestServices', _guest_services__WEBPACK_IMPORTED_MODULE_1__["guestServices"]);

GUEST_MODULE.component('guestListComponent', _guest_list_component__WEBPACK_IMPORTED_MODULE_0__["guestListComponent"]);

GUEST_MODULE.config(['$uiRouterProvider', function ($uiRouterProvider) {
    var stateRegistry = $uiRouterProvider.stateRegistry;
    stateRegistry.register(_guest_states__WEBPACK_IMPORTED_MODULE_2__["guestState"]);
    stateRegistry.register(_guest_states__WEBPACK_IMPORTED_MODULE_2__["guestListState"]);
}]);

/***/ }),

/***/ "./app/modules/guest/guest.services.js":
/*!*********************************************!*\
  !*** ./app/modules/guest/guest.services.js ***!
  \*********************************************/
/*! exports provided: guestServices, default */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "guestServices", function() { return guestServices; });
﻿guestServices.$inject = ['$http'];

function guestServices($http) {

    var api = window.location.origin + window.location.pathname + 'api/';
    var service = {};

    service.getGuests = () => $http.get(api + 'guest/');

    return service;
}

/* harmony default export */ __webpack_exports__["default"] = (angular.module('services.guestServices', [])
    .service('guestServices', guestServices).name);


/***/ }),

/***/ "./app/modules/guest/guest.states.js":
/*!*******************************************!*\
  !*** ./app/modules/guest/guest.states.js ***!
  \*******************************************/
/*! exports provided: guestState, guestListState */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "guestState", function() { return guestState; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "guestListState", function() { return guestListState; });
﻿const guestState = {
    parent: 'app',
    name: 'guests',
    url: '/guests',
    dsr: true,
    sticky: true,
    views: {
        'viewGuest': {
            template: '<div ui-view="viewList"></div><div ui-view="viewDetail"></div>'
        }
    },
    deepStateRedirect: {
        default: { state: 'guests.list' }
    }
};

const guestListState = {
    name: 'guests.list',
    views: {
        'viewList': {
            component: 'guestListComponent'
        }
    }
};

/***/ })

}]);
//# sourceMappingURL=4.js.map