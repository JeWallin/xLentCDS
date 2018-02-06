
var accountController = function ($scope, accountService) {

    $scope.accounts = [];

    init();

    function init() {
        $scope.accounts = accountService.getAccounts();

        //We need this shit... trust me!
        setTimeout(function () {
            $scope.$apply(function () {
            });
        }, 1000);
    }
};