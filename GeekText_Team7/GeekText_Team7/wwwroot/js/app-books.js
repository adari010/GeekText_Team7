// app-books.js
(function () {

    "use strict";

    // Creating the Module
    angular.module("app-books", ["simpleControls", "ngRoute"])
        .config(function ($routeProvider) {

            $routeProvider.when("/", {
                controller: "booksController",
                controllerAs: "vm",
                templateUrl: "/views/booksView.html"
            });

            $routeProvider.otherwise({ redirectTo: "/" });

        });

})();