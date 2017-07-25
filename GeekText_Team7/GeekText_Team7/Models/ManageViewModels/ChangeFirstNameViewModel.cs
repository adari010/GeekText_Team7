using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.Models.ManageViewModels
{
    public class ChangeFirstNameViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "New First Name")]
        public string NewFirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Confirm new First Name")]
        [Compare("NewFirstName", ErrorMessage = "The new first name and confirmation first name do not match.")]
        public string ConfirmFirstName { get; set; }
    }
}