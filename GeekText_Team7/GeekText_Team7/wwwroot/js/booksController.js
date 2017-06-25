// usersController.js
(function () {

    "use strict";

    // Getting the existing module
    angular.module("app-books")
        .controller("booksController", booksController);

    function booksController($http) {

        var vm = this;

        vm.books = [];

        vm.errorMessage = "";
        vm.isBusy = true;

        $http.get("/api/books")
            .then(function (response) {
                // Success
                angular.copy(response.data, vm.books);
            }, function (error) {
                // Failure
                vm.errorMessage = "Failed to load data: " + error;
            })
            .finally(function () {
                vm.isBusy = false;
            });

    }

})();