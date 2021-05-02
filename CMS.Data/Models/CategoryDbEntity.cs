using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMS.Data.Models
{
    public class CategoryDbEntity : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public List<PostDbEntity> Posts { get; set; }
    }
}
