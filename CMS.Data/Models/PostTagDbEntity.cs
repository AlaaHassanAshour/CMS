using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Data.Models
{
    public class PostTagDbEntity
    {
        public int PostId { get; set; }
        public PostDbEntity Post { get; set; }

        public int TagId { get; set; }
        public TagDbEntity Tag { get; set; }
    }
}
