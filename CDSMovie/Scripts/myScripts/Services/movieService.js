
var movieService = function () {

    

    this.getMovies = function()
    {
        var movies = [];

        $.get("http://localhost:49974/api/movie/",
            function (data) {
                //console.log(data);
                for (i = 0; i < data.length; i++) {
                    movies.push({
                        Name: data[i].Name,
                        ImdbID: data[i].ImdbID,
                        Category: data[i].Category
                    });
                }

                //movies = data;
            });
        return movies;
    };

}