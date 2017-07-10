// bookauthorsController.js
(function () {

    "use strict";

    // Getting the existing module
    angular.module("app-bookauthors")
        .controller("bookauthorsController", bookauthorsController);

    function bookauthorsController($http) {

        var vm = this;

        vm.bookauthors = [];

        vm.errorMessage = "";
        vm.isBusy = true;

        $http.get("/api/bookauthors")
            .then(function (response) {
                // Success
                angular.copy(response.data, vm.bookauthors);
            }, function (error) {
                // Failure
                vm.errorMessage = "Failed to load data: " + error;
            })
            .finally(function () {
                vm.isBusy = false;
            });

    }

})();