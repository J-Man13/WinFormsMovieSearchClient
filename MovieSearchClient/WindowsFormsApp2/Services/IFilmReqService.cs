using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSearchClient.Model;

namespace MovieSearchClient.Services
{
    interface IFilmReqService
    {
        IEnumerable<Film> getFilmsFoolBodies(string filmName);
    }
}
