using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearchClient.Model
{
    public class Film
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string ImdbID { get; set; }
        public string Type { get; set; }
        public string PosterLink { get; set; }
  

        public override string ToString()
        {
            return Title.ToString();
        }
    }
}
