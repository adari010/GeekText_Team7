using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.Models.ManageViewModels
{
    public class ChangeNameViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "New Name")]
        public string NewName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Confirm new Name")]
        [Compare("NewName", ErrorMessage = "The new Name and confirmation Name do not match.")]
        public string ConfirmName { get; set; }
    }
}