// app-bookauthors.js
(function () {

    "use strict";

    // Creating the Module
    angular.module("app-bookauthors", ["simpleControls", "ngRoute"])
        .config(function ($routeProvider) {

            $routeProvider.when("/", {
                controller: "bookauthorsController",
                controllerAs: "vm",
                templateUrl: "/views/bookauthorsView.html"
            });

            $routeProvider.otherwise({ redirectTo: "/" });

        });

})();