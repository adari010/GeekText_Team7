using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.ViewModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Biography { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
