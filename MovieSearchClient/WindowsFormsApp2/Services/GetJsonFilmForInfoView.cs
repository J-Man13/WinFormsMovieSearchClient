using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2.Services
{
    class GetJsonFilmForInfoView : IFilmForInfoReqService
    {
        private static string WEB_REQ_WITH_API_KEY = "http://www.omdbapi.com/?apikey=a75f6f15&i=";

        public FilmForInfoView getFilmForInfoView(string ImdbID)
        {
            JObject jObject = getJSONString(ImdbID);
            FilmForInfoView filmForInfoView = new FilmForInfoView
            {
                Title = jObject["Title"].ToString(),
                Director = jObject["Director"].ToString(),
                Runtime = jObject["Runtime"].ToString(),
                Released = jObject["Released"].ToString(),
                Genre = jObject["Genre"].ToString(),
                Plot = jObject["Plot"].ToString(),
                PosterLink = jObject["Poster"].ToString(),
                Response = jObject["Response"].ToString()
            };
            return filmForInfoView;
        }

        private JObject getJSONString(string ImdbID)
        {
            WebClient webClient = new WebClient();
            string jsonString = webClient.DownloadString(WEB_REQ_WITH_API_KEY + ImdbID);
            return JsonConvert.DeserializeObject(jsonString) as JObject;
        }
    }
}
