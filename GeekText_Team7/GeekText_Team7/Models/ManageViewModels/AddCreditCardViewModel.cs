using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace GeekText_Team7.Models.ManageViewModels
{
    public class AddCreditCardViewModel
    {

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
        [MinLength(3, ErrorMessage = "Invalid Billing Address. Please try again")]
        public string BillingAddress { get; set; }

        [Required(ErrorMessage = "Please enter a City")]
        [DataType(DataType.Text)]
        [MinLength(2, ErrorMessage = "Invalid City. Please try again")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a State")]
        [DataType(DataType.Text)]
        [MinLength(2, ErrorMessage = "Invalid State. Please try again")]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a valid Zip Code")]
        [DataType(DataType.Text)]
        [StringLength(5, ErrorMessage = "Invalid Zip Code. Please try again")]
        [MinLength(5, ErrorMessage = "Zip Code too short. Please enter 5 digit zip")]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter a credit card number")]
        [StringLength(16, ErrorMessage = "Invalid Card Number")]
        [MinLength(16, ErrorMessage = "Credit Card number too short. Please try again")]
        [DataType(DataType.Text)]
        [Display(Name = "Card Number")]
        public string CCNumber { get; set; }

        [Required(ErrorMessage = "Please enter a CVV number")]
        [MinLength(3, ErrorMessage = "CVV number too short. Please try again")]
        [StringLength(3, ErrorMessage = "Invalid CVV number. Please try again")]
        [DataType(DataType.Text)]
        [Display(Name = "CVV")]
        public string CVV { get; set; }

        [Required(ErrorMessage = "Please enter expiration date in MM/YYYY format")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0:MM/YYYY}")]
        [MinLength(7, ErrorMessage = "Please enter expiration date in MM/YYYY format")]
        [StringLength(7, ErrorMessage = "Please enter expiration date in MM/YYYY format")]
        [Display(Name = "Expiration Date")]
        public string ExpirationDate { get; set; }
    }
}