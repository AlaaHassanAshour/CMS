using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Core.ViewModel
{
   public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public CategoryViewModel Category { get; set; }
        public List<TagViewModel> Tags { get; set; }
        public List<string> Images { get; set; }
    }
}
