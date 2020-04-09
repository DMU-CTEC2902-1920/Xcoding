using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XCodingGameReview.Models
{
    public class Developer
    {
        public virtual int DeveloperID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}