using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Core.ViewModel
{
    public class TokenViewModel
    {
        public string AcessToken { get; set; }

        public DateTime ExpireAt { get; set; }
    }
}
