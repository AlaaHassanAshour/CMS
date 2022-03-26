using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Core.Dto
{
   public class CreatePostDto
    {
        public int? Id{ get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int CategoryId { get; set; }
        public List<int> TagsId { get; set; }
        public List<IFormFile> Images { get; set; }
    }
}
