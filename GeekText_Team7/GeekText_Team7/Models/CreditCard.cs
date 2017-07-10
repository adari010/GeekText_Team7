using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public long CreditCardNumber { get; set; }
        public string BankName { get; set; }
        public DateTime ExpirationDate { get; set; }

        public User User { get; set; }
    }
}