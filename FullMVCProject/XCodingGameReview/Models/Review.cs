using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XCodingGameReview.Models
{
    public class Review
    {
        public virtual int ReviewID { get; set; }
        public virtual Int32 GameID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual Int32 Score { get; set; }
    }
}