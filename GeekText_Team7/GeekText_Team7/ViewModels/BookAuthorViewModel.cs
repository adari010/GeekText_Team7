using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.ViewModels
{
    public class BookAuthorViewModel
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public int Order { get; set; }
    }
}
