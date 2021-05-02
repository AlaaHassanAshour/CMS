using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMS.Data.Models
{
    public class PostImageDbEntity
    {
        public int Id { get; set; }

        public int PostId { get; set; }
        public PostDbEntity Post { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
