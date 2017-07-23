using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.Models.BookAuthorViewModels
{
    public class BookIndexData
    {
        public IEnumerable<Book> Book { get; set; }
        public IEnumerable<BookAuthor> BookAuthor { get; set; }
        public IEnumerable<Author> Author { get; set; }

    }
}
