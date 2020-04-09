using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XCodingGameReview.Models
{
    public class Game
    {
        public virtual Int32 GameID { get; set; }
        public virtual Int32 DeveloperID { get; set; }
        public virtual String Name { get; set; }
        public virtual String Genre { get; set; }
        public virtual String ReleaseDate { get; set; }
        public virtual String Trailer { get; set; }
        public virtual String Image { get; set; }
    }
}