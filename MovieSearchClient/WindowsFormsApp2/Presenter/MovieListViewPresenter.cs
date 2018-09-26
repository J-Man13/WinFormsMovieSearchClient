using MovieSearchClient.Model;
using MovieSearchClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearchClient.Presenter
{
    

    class MovieListViewPresenter
    {
        private IFilmReqService iFilmReqService;

        public MovieListViewPresenter()
        {
            iFilmReqService = new GetJsonFilmsList();
        }

        public IEnumerable<Film> getFilms(string searchFilm)
        {
            return iFilmReqService.getFilmsFoolBodies(searchFilm);
        }

    }
}
