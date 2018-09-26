using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MovieSearchClient.Model;
using System.Windows.Forms;

namespace MovieSearchClient.Services
{
    class GetJsonFilmsList : IFilmReqService
    {
        private static string WEB_REQ_WITH_API_KEY = "http://www.omdbapi.com/?apikey=a75f6f15&s=";

        public IEnumerable<Film> getFilmsFoolBodies(string filmName)
        {
            JObject JSON;
            try {
                JSON = getJSONString(filmName);
            }
            catch(Exception)
            {
                return null;
            }

            LinkedList<Film> linkedList = new LinkedList<Film>();

            if (JSON["Response"].ToString().Equals("False"))
            {
                return linkedList;
            }

            foreach (JToken item in JSON["Search"])
            {
                Film film = new Film
                {
                    Title = item["Title"].ToString(),
                    Year = item["Year"].ToString(),
                    ImdbID = item["imdbID"].ToString(),
                    Type = item["Type"].ToString(),
                    PosterLink = item["Poster"].ToString(),
                };
                linkedList.AddLast(film);
            }
            
            return linkedList;
        }

        private JObject getJSONString(string filmName)
        {
            WebClient webClient = new WebClient();
            string jsonString = webClient.DownloadString(WEB_REQ_WITH_API_KEY+ filmName);
            return JsonConvert.DeserializeObject(jsonString) as JObject;
        }
    }
}
