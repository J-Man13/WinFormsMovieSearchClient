using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;
using WindowsFormsApp2.Services;

namespace MovieSearchClient.Presenter
{
    class MovieInfoViewPresenter
    {
        IFilmForInfoReqService iFilmForInfoReqService;

        public MovieInfoViewPresenter()
        {
            iFilmForInfoReqService = new GetJsonFilmForInfoView();
        }

        public FilmForInfoView getFilmForInfoView(string ImdbID)
        {
            return iFilmForInfoReqService.getFilmForInfoView(ImdbID);
        }
    }
}