using System.ComponentModel.DataAnnotations;

namespace FullMVCProjectNew.Models
{
    public class AnGenre
    {
        //declare as primary key
        [Key]
        public virtual int GenreID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}