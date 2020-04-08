using System.ComponentModel.DataAnnotations;

namespace FullMVCProjectNew.Models
{
    public class AnReview
    {
        //declare as primary key
        [Key]
        public virtual int ReviewID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }
        public virtual string Score { get; set; }

        //declare game foreign key
        public virtual int GameID { get; set; }
        public virtual AnGame Game { get; set; }
        //declare user foreign key
        public virtual int UserID { get; set; }
        public virtual AnUser User { get; set; }
        
    }
}