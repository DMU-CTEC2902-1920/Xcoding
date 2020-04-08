using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FullMVCProjectNew.Models
{
    public class GameDataInitialiser: DropCreateDatabaseAlways<AnGameContext>
    {
        protected override void Seed(AnGameContext context)
        {
            AnGenre genre1 = new AnGenre();
            genre1.GenreID = 1;
            genre1.Name = "MOBA";
            genre1.Description = "Multiplayer Online Battle Arena";
            context.AnGenres.Add(genre1);

            AnGenre genre2 = new AnGenre();
            genre2.GenreID = 2;
            genre2.Name = "FPS";
            genre2.Description = "First Person Shooter";
            context.AnGenres.Add(genre2);

            AnGame game1 = new AnGame();
            game1.GameID = 1;
            game1.Name = "League of Legends";
            game1.Description = "The most popular MOBA in the world";
            game1.Price = 0;
            game1.AgeRating = "12+";
            game1.DateReleased = Convert.ToDateTime("27/10/2009");
            game1.TrailerURL = "https://www.youtube.com/embed/7O21Z6vgtmY";
            game1.ImageSRC = "https://www.riotgames.com/darkroom/800/da85e92aaf87f26181ded41afe03b1dc:aaeeccb4b282b616ef907ec68c40f2b7/lol-logo-rendered-hi-res.png";
            game1.Genre = genre1;
            game1.GenreID = 1;
            context.AnGames.Add(game1);

            AnGame game2 = new AnGame();
            game2.GameID = 2;
            game2.Name = "Counter-strike: Global Offensive";
            game2.Description = "A strategical first person shooter";
            game2.Price = 0;
            game2.AgeRating = "18+";
            game2.DateReleased = Convert.ToDateTime("21/08/2012");
            game2.TrailerURL = "https://www.youtube.com/embed/edYCtaNueQY";
            game2.ImageSRC = "https://i.dlpng.com/static/png/6628007_preview.png";
            game2.Genre = genre2;
            game2.GenreID = 2;
            context.AnGames.Add(game2);

            base.Seed(context);
        }
    }
}