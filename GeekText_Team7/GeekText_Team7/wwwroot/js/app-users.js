// app-users.js
(function () {

    "use strict";

    // Creating the Module
    angular.module("app-users", ["simpleControls", "ngRoute"])
        .config(function ($routeProvider) {

            $routeProvider.when("/", {
                controller: "usersController",
                controllerAs: "vm",
                templateUrl: "/views/usersView.html"
            });

            $routeProvider.otherwise({ redirectTo: "/" });

        });

})();