// authorsController.js
(function () {

    "use strict";

    // Getting the existing module
    angular.module("app-authors")
        .controller("authorsController", authorsController);

    function authorsController($http) {

        var vm = this;

        vm.authors = [];

        vm.errorMessage = "";
        vm.isBusy = true;

        $http.get("/api/authors")
            .then(function (response) {
                // Success
                angular.copy(response.data, vm.authors);
            }, function (error) {
                // Failure
                vm.errorMessage = "Failed to load data: " + error;
            })
            .finally(function () {
                vm.isBusy = false;
            });

    }

})();