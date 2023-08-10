using CinemaTicketAutomation.Enums;
using CinemaTicketAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketAutomation.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:\\Users\\ozgur\\OneDrive\\Masaüstü\\staj\\CinemaTicketAutomation\\CinemaTicketAutomation\\Pictures\\";
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Yıldızlararası",
                    category =  Category.bilim_kurgu,
                    minute = "2 saat 49 dakika",
                    price = 50,
                    picturePath = basePath + "yıldızlararası.jpg"
                },
                 new Movie()
                {
                    movieName = "Nefesini Tut",
                    category =  Category.gerilim,
                    minute = "1 saat 28 dakika",
                    price = 40,
                    picturePath = basePath + "nefesini_tut.jpg"
                },
                  new Movie()
                {
                    movieName = "Üç Aptal",
                    category =  Category.komedi,
                    minute = "2 saat 51 dakika",
                    price = 60,
                    picturePath = basePath + "üç_aptal.jpg"
                },
                  new Movie()
                {
                    movieName = "Geleceğe Dönüş",
                    category =  Category.bilim_kurgu,
                    minute = "1 saat 56 dakika",
                    price = 50,
                    picturePath = basePath + "gelecege_donus.jpg"
                },
                    new Movie()
                {
                    movieName = "Jumanji",
                    category =  Category.macera,
                    minute = "1 saat 44 dakika",
                    price = 50,
                    picturePath = basePath + "jumanji.jpg"
                },
                    new Movie()
                {
                    movieName = "Warcraft",
                    category =  Category.fantastik,
                    minute = "2 saat 3 dakika",
                    price = 40,
                    picturePath = basePath + "warcraft.jpg"
                },

            };
        }
    }
}
