using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.Models.ManageViewModels
{
    public class ChangeLastNameViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "New Last Name")]
        public string NewLastName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Confirm new Last Name")]
        [Compare("NewLastName", ErrorMessage = "The new last name and confirmation last name do not match.")]
        public string ConfirmLastName { get; set; }
    }
}