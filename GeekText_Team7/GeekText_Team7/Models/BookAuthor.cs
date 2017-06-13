﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.Models
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public byte Order { get; set; }

        public Book Book { get; set; }
        public Author Author { get; set; }

    }
}