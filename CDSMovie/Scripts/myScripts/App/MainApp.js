
var mainApp = angular.module('mainApp', []);

mainApp.service('movieService', movieService);
mainApp.controller('movieController', movieController);

mainApp.service('accountService', accountService);
mainApp.controller('accountController', accountController);