using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FullMVCProjectNew.Models
{
    public class AnGame
    {
        //declare as primary key
        [Key]
        public virtual int GameID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public decimal Price { get; set; }
        public virtual string AgeRating { get; set; }
        public virtual int Score { get; set; }
        public virtual string DateReleased { get; set; }
        public virtual string TrailerEmbed { get; set; }
        public string ImageSRC { get; set; }
        //declare genre foreign key
        public virtual int GenreID { get; set; }
        public virtual AnGenre Genre { get; set; }
    }
}