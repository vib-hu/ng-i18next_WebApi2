# ng-i18next_WebApi2
Using ng-i18next for localization on client side with webapi for providing Json. 

# Initialize I18Next with Json data from API.
# File : Main.Js

if (window.i18next) {
    window.i18next
        .use(window.i18nextSprintfPostProcessor);

    (function InitializeIn18next() {
        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function () {
            if (this.readyState == 4 && this.status == 200) {
                entranslation = JSON.parse(JSON.parse(this.responseText)).En;
                artranslation = JSON.parse(JSON.parse(this.responseText)).Ar;
                this.responseText;
            }
        };
        xhttp.open("GET", "http://*****:****/api/GetAllLanguageResources", false);
        xhttp.send();

        window.i18next.init({
            lng: 'En',
            debug: true,
            resources: {
                En: {
                    translation: entranslation
                },
                Ar: {
                    translation: artranslation
                }
            }
        }, function (err, t) {

        });
    })();
}

angular.module('MyApp', ['jm.i18next']).controller('MyDirectiveCtrl', function ($rootScope, $scope, $timeout, $i18next, $filter) {

    'use strict';

    $scope.i18nextReady = false;

    $scope.$on('i18nextLanguageChange', function () {
        console.log('Language has changed!');
        if (!$scope.i18nextReady) {
            $timeout(function () {
                $scope.i18nextReady = true;
            }, 500);
        }
    });

    $scope.changeLng = function (lng) {
        $i18next.changeLanguage(lng);
    };
});

# Using I18Next In HTML.
# File : Index.html

<div ng-controller="MyDirectiveCtrl">
		<p>
			Change language to: <br>
			<a href="#" ng-click="changeLng('En')">English</a><br>
			<a href="#" ng-click="changeLng('Ar')">Arabic</a>
		</p>
		<h2 ng-i18next="Key1"></h2>
		<p ng-i18next="Key1"></p>
	</div>
  

