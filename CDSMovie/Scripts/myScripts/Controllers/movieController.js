
var movieController = function MovieController($scope, movieService) {

    $scope.movies = [];

    init();

    function init(){
        $scope.movies = movieService.getMovies();

        //We need this shit... trust me!
        setTimeout(function () {
            $scope.$apply(function () {
            });
        }, 1000);
    }
}