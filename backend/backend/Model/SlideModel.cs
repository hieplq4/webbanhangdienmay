﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SlideModel
    {
        public int ID { get; set; }
        public string? Anh { get; set; }
        public int TrangThai { get; set; }
        public IFormFile? File { get; set; }
    }
}
