﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Core.ViewModel
{
    public class PagingViewModel
    {
        public int NumberOfPages { get; set; }

        public int CureentPage { get; set; }

        public object Data { get; set; }
    }
}
