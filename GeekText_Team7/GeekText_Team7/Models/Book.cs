using System;
using System.Collections.Generic;

namespace GeekText_Team7.Models
{
    public partial class Book
    {
        public Book()
        {
            BookAuthor = new HashSet<BookAuthor>();
        }

        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int Orders { get; set; }
        public int TechValleyTimesOrders { get; set; }
        public double Price { get; set; }
        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
        public virtual User User { get; set; }
    }
}
