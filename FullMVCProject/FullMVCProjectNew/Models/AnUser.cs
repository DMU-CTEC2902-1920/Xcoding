using System.ComponentModel.DataAnnotations;

namespace FullMVCProjectNew.Models
{
    public class AnUser
    {
        //declare as primary key
        [Key]
        public virtual int UserID { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
}