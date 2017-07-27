using System;
using System.Collections.Generic;

namespace GeekText_Team7.Models
{
    public partial class Author
    {
        public Author()
        {
            BookAuthor = new HashSet<BookAuthor>();
        }

        public int Id { get; set; }
        public string Biography { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
    }
}
