using System;
using System.Collections.Generic;

namespace GeekText_Team7.Models
{
    public partial class CreditCard
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int UserId { get; set; }
        public long CreditCardNumber { get; set; }

        public virtual User User { get; set; }
    }
}
