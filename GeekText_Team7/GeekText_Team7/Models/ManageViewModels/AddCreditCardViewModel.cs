using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace GeekText_Team7.Models.ManageViewModels
{
    public class AddCreditCardViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Cardholder's First Name is Required")]
        [DataType(DataType.Text)]
        [Display(Name = "CardHolder's First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Cardholder's Last Name is Required")]
        [DataType(DataType.Text)]
        [Display(Name = "CardHolder's Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Cardholder's Billing Address is Required")]
        [DataType(DataType.Text)]
        [Display(Name = "Billing Address")]
        public string BillingAddress { get; set; }

        [Required(ErrorMessage = "Please enter a City")]
        [DataType(DataType.Text)]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a State")]
        [DataType(DataType.Text)]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a Zip Code")]
        [DataType(DataType.Text)]
        [MaxLength(5)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Invalid Card Number")]
        [DataType(DataType.Text)]
        [Display(Name = "Card Number")]
        public string CCNumber { get; set; }

        [Required(ErrorMessage = "Invalid Expiration Date")]
        [DataType(DataType.Date)]
        [Display(Name = "Expiration Date")]
        public DateTime ExpirationDate { get; set; }
    }
}




