using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMS.Data.Models
{
    public class PostDbEntity : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        public int CategoryId { get; set; }
        public CategoryDbEntity Category { get; set; }
        public List<PostImageDbEntity> PostImages { get; set; }
        public List<PostTagDbEntity> PostTags { get; set; }
    }
}
