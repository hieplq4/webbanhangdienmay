﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PhanTrangModel
    {
        public int TotalItems { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public dynamic Data { get; set; }
    }
}
