using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.Models.ManageViewModels
{
    public class ChangeUserNameViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Current username")]
        public string OldUserName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "New username")]
        public string NewUserName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Confirm new username")]
        [Compare("NewUserName", ErrorMessage = "The new username and confirmation username do not match.")]
        public string ConfirmUserName { get; set; }
    }
}