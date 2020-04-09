using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XCodingGameReview.Models
{
    public class Genre
    {
        public List<string> GenreList
        {
            get
            {
                List<string> myGenres = new List<string>();
                myGenres.Add("Action");
                myGenres.Add("Adventure");
                myGenres.Add("Fighting");
                myGenres.Add("Platform");
                myGenres.Add("Puzzle");
                myGenres.Add("Racing");
                myGenres.Add("Role-playing");
                myGenres.Add("Shooter");
                myGenres.Add("Simulation");
                myGenres.Add("Sports");
                myGenres.Add("Strategy");
                return myGenres;
            }
        }
    }
}