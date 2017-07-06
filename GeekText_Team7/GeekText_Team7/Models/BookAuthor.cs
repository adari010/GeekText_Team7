using System;
using System.Collections.Generic;

namespace GeekText_Team7.Models
{
    public partial class BookAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public byte Order { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
