using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.Models.ManageViewModels
{
    public class ChangeAddressViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "New Address")]
        public string NewAddress { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Confirm new Address")]
        [Compare("NewAddress", ErrorMessage = "The new address and confirmation address do not match.")]
        public string ConfirmAddress { get; set; }
    }
}