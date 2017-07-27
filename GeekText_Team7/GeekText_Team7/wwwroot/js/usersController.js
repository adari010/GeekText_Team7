// usersController.js
(function () {

    "use strict";

    // Getting the existing module
    angular.module("app-users")
        .controller("usersController", usersController);

    function usersController($http) {

        var vm = this;

        vm.users = [];

        vm.errorMessage = "";
        vm.isBusy = true;

        $http.get("/api/users")
            .then(function (response) {
                // Success
                angular.copy(response.data, vm.users);
            }, function (error) {
                // Failure
                vm.errorMessage = "Failed to load data: " + error;
            })
            .finally(function () {
                vm.isBusy = false;
            });

    }

})();