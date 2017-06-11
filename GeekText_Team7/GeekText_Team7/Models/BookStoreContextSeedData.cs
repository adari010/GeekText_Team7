using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekText_Team7.Models
{
    public class BookStoreContextSeedData
    {
        private BookStoreContext _context;

        public BookStoreContextSeedData(BookStoreContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {
            if (!_context.Users.Any())
            {
                var testUser = new User()
                {
                    DOB = new DateTime(1983, 6, 23),
                    Sex = "Male",
                    FirstName = "Rob",
                    LastName = "Stark",
                    Email = "rob@starkfamily.com",
                    CreditCards = new List<CreditCard>()
                    {
                        new CreditCard() { CreditCardNumber = 9432749874, BankName = "Lannister Bank", ExpirationDate = new DateTime(2019, 3, 9)},
                        new CreditCard() { CreditCardNumber = 9432749875, BankName = "Stark Bank", ExpirationDate = new DateTime(2020, 8, 10)}
                    }
                };
                _context.Users.Add(testUser);
                _context.CreditCards.AddRange(testUser.CreditCards);

                var testUser1 = new User()
                {
                    DOB = new DateTime(1990, 2, 4),
                    Sex = "Male",
                    FirstName = "Jon",
                    LastName = "Snow",
                    Email = "jon@snow.com",
                    CreditCards = new List<CreditCard>()
                    {
                        new CreditCard() { CreditCardNumber = 9432749876, BankName = "Targaryen Bank", ExpirationDate = new DateTime(2015, 1, 9)},
                    }
                };
                _context.Users.Add(testUser1);
                _context.CreditCards.AddRange(testUser1.CreditCards);

                await _context.SaveChangesAsync();
            }

            if (!_context.Books.Any())
            {
                var testBook = new Book()
                {
                    ISBN = 12394,
                    Title = "Don Quixote",
                    Description = "Alonso Quixano, lives in an unnamed section of La Mancha with his niece..."
                };
                _context.Books.Add(testBook);

                var testBook1 = new Book()
                {
                    ISBN = 12395,
                    Title = "The Odyssey",
                    Description = "The Odyssey is one of two major ancient Greek epic poems attributed to Homer..."
                };
                _context.Books.Add(testBook1);

                await _context.SaveChangesAsync();
            }

        }

    }
}
