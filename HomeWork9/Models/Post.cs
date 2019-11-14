﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork9.Models
{
    public class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ImgPath { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string PublicationDate { get; set; } = DateTime.Now.ToShortDateString();
    }
}
