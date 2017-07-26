using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;


namespace GeekText_Team7.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<ApplicationUser> FirstName { get; set; }

        public bool HasUsername { get; set; }

        public bool HasPassword { get; set; }

        public IList<UserLoginInfo> Logins { get; set; }

        public string PhoneNumber { get; set; }

        public bool TwoFactor { get; set; }

        public bool BrowserRemembered { get; set; }

        //public IFormFile AvatarImage { get; set; }
        public string Email { get; internal set; }
    }
}
