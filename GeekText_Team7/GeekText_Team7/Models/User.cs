using System;
using System.Collections.Generic;

namespace GeekText_Team7.Models
{
    public partial class User
    {
        public User()
        {
            Book = new HashSet<Book>();
            CreditCard = new HashSet<CreditCard>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string City { get; set; }
        public DateTime Dob { get; set; }
        public string Sex { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Book> Book { get; set; }
        public virtual ICollection<CreditCard> CreditCard { get; set; }
    }
}
