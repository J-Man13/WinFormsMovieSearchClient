using MovieSearchClient.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;

namespace MovieSearchClient.View
{
    public partial class MovieInfoForm : Form
    {
        MovieInfoViewPresenter movieInfoViewPresenter;

        public MovieInfoForm()
        {
            movieInfoViewPresenter = new MovieInfoViewPresenter();
            InitializeComponent();
        }
        
        public void showFilmContent(string ImdbID)
        {
            FilmForInfoView filmForInfoView = movieInfoViewPresenter.getFilmForInfoView(ImdbID);
            labelFilmName.Text = "Film : "+filmForInfoView.Title;
            labelDirector.Text = "Director : " + filmForInfoView.Director;
            labelRunTime.Text = "Run time : " + filmForInfoView.Runtime;
            labelReleaseDate.Text = "Release date : " + filmForInfoView.Released;
            labelGenre.Text = "Genre : " + filmForInfoView.Genre;
            readOnlyRichTextBox1.Text = filmForInfoView.Plot;

            string localFilename = "";

            if (filmForInfoView.PosterLink.Equals("N/A"))
                localFilename = @"c:\MouseSearchClientPhotos\NoImage.jpg";
            else
            {
                localFilename = @"c:\MouseSearchClientPhotos\" + ImdbID + ".jpg";

                if (!System.IO.File.Exists(localFilename))
                {
                    try {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile(filmForInfoView.PosterLink, localFilename);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No internet connection or link expired");
                    }
                }
            }
            pictureBoxFilmSearch.Image = Image.FromFile(localFilename);
        }

    }
}
