using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.Models
{
    public class User
    {
        public int ID { get; set; }
        public DateTime DOB { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string Alias { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public ICollection<CreditCard> CreditCard { get; set; }
        public ICollection<Book> Book { get; set; }

    }
}
