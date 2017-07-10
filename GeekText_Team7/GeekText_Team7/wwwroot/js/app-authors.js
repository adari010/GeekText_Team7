// app-authors.js
(function () {

    "use strict";

    // Creating the Module
    angular.module("app-authors", ["simpleControls", "ngRoute"])
        .config(function ($routeProvider) {

            $routeProvider.when("/", {
                controller: "authorsController",
                controllerAs: "vm",
                templateUrl: "/views/authorsView.html"
            });

            $routeProvider.otherwise({ redirectTo: "/" });

        });

})();