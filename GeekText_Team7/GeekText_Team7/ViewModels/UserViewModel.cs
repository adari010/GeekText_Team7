using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string City{ get; set; }
        public string Sex{ get; set; }
        public string State{ get; set; }
        public string Street{ get; set; }
        public string ZipCode{ get; set; }
        public string Email { get; set; }
    }
}
