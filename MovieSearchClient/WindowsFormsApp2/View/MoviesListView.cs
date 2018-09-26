using MovieSearchClient.Model;
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

namespace MovieSearchClient.View
{
    public partial class MoviesListView : Form
    {
        MovieListViewPresenter movieListViewPresenter;

        public MoviesListView()
        {
            try
            {
                if (!System.IO.Directory.Exists(@"c:\MouseSearchClientPhotos"))
                    System.IO.Directory.CreateDirectory(@"c:\MouseSearchClientPhotos");

                if (!System.IO.File.Exists(@"c:\MouseSearchClientPhotos\MovieClub.jpg"))
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://www.london-unattached.com/wp-content/uploads/2018/07/Rooftop-Cinema-Club.jpg", @"c:\MouseSearchClientPhotos\MovieClub.jpg");
                }

                if (!System.IO.File.Exists(@"c:\MouseSearchClientPhotos\NoImage.jpg"))
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://vignette.wikia.nocookie.net/bokurawaminnakawaisou/images/f/f6/NoImage.jpg/revision/latest?cb=20140414154002", @"c:\MouseSearchClientPhotos\NoImage.jpg");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No internet connection or link expired");
            }
            InitializeComponent();
            pictureBoxFilmSearch.Image = Image.FromFile(@"c:\MouseSearchClientPhotos\MovieClub.jpg");
            movieListViewPresenter = new MovieListViewPresenter();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            showFoundFilms();
        }

        private void showFoundFilms()
        {
            pictureBoxFilmSearch.Image = Image.FromFile(@"c:\MouseSearchClientPhotos\MovieClub.jpg");
            string searchFilm = textBoxSearch.Text;
            listBoxResults.Items.Clear();

            try
            {
                if (movieListViewPresenter.getFilms(searchFilm).ToList().Count == 0)
                {
                    MessageBox.Show("Movie not found!");
                    return;
                }else
                    movieListViewPresenter.getFilms(searchFilm).ToList().ForEach((i) => listBoxResults.Items.Add(i));
            }
            catch (Exception)
            {
                MessageBox.Show("No internet connection or link expired");
            }
        }

        private void listBoxResults_DisplayPhoto(Film film)
        {
            if (film == null) return;
            string localFilename = "";

            if (film.PosterLink.Equals("N/A"))
                localFilename = @"c:\MouseSearchClientPhotos\NoImage.jpg";
            else
            {
                localFilename = @"c:\MouseSearchClientPhotos\" + film.ImdbID + ".jpg";

                if (!System.IO.File.Exists(localFilename))
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(film.PosterLink, localFilename);
                }
            }
            pictureBoxFilmSearch.Image = Image.FromFile(localFilename);
        }

        private void listBoxResults_MouseClick(object sender, MouseEventArgs e)
        {
            Film film = listBoxResults.SelectedItem as Film;
            listBoxResults_DisplayPhoto(film);
        }


        private void listBoxResults_KeyDown(object sender, KeyEventArgs e)
        {
            Film film = listBoxResults.SelectedItem as Film;
            listBoxResults_DisplayPhoto(film);
        }

        private void listBoxResults_KeyUp(object sender, KeyEventArgs e)
        {
            Film film = listBoxResults.SelectedItem as Film;
            listBoxResults_DisplayPhoto(film);
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                showFoundFilms();
            }
        }

        private void button_More_Details(object sender, EventArgs e)
        {
            callMovieInfoView();
        }

        private void listBoxResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            callMovieInfoView();
        }

        private void callMovieInfoView()
        {
            Film film = listBoxResults.SelectedItem as Film;
            if (film == null)
                return;
            else
            {
                MovieInfoForm movieInfoForm = new MovieInfoForm();
                movieInfoForm.showFilmContent(film.ImdbID);
                movieInfoForm.ShowDialog();

            }
        }

        private void listBoxResults_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                callMovieInfoView();
        }
    }
}
