using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GeekText_Team7.Models
{
    public class BookStoreRepository : IBookStoreRepository
    {
        private BookStoreContext _context;
        private ILogger<BookStoreRepository> _logger;

        public BookStoreRepository(BookStoreContext context, ILogger<BookStoreRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public User GetUsersByName(string userFirstName)
        {
            return _context.Users.Where(u => u.FirstName == userFirstName).FirstOrDefault();
        }

        public IEnumerable<User> GetAllUsers()
        {
            _logger.LogInformation("Getting All Users from the Database");

            return _context.Users.ToList();
        }

        public IEnumerable<Book> GetBooks()
        {
            _logger.LogInformation("Getting Books from the Database");

            return _context.Books.ToList();
        }

        public IEnumerable<BookAuthor> GetBookAuthors()
        {
            _logger.LogInformation("Getting Books from the Database");

            return _context.BookAuthors.ToList();
        }

        public IEnumerable<Author> GetAuthors()
        {
            _logger.LogInformation("Getting Books from the Database");

            return _context.Authors.ToList();
        }
    }
}
