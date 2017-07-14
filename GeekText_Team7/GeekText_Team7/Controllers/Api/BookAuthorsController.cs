using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GeekText_Team7.Models;
using GeekText_Team7.Models.BookAuthorViewModels;

namespace GeekText_Team7.Controllers.Api
{
    public class BookAuthorsController : Controller
    {
        private readonly BookStoreSummer17Context _context;

        public BookAuthorsController(BookStoreSummer17Context context)
        {
            _context = context;    
        }

        // GET: BookAuthors
        public async Task<IActionResult> Index()
        {
            var viewModel = new BookIndexData();

            viewModel.BookAuthor = await _context.BookAuthor
                .Include(c => c.Book)
                .Include(b => b.Author)
                .AsNoTracking()
                .ToListAsync();

            viewModel.Book = await _context.Book
                .Include(c => c.BookAuthor)
                .AsNoTracking()
                .ToListAsync();

            viewModel.Author = await _context.Author
                .Include(c => c.BookAuthor)
                .AsNoTracking()
                .ToListAsync();

            return View(viewModel);
        }

        // GET: BookAuthors/BookDetails/5
        public async Task<IActionResult> BookDetails(int id)
        {
            var viewModel = new BookIndexData();

            viewModel.BookAuthor = await _context.BookAuthor
                .Include(c => c.Book)
                .Include(b => b.Author)
                .AsNoTracking()
                .ToListAsync();

            viewModel.Book = await _context.Book
                .Include(c => c.BookAuthor)
                .AsNoTracking()
                .ToListAsync();

            viewModel.Author = await _context.Author
                .Include(c => c.BookAuthor)
                .AsNoTracking()
                .ToListAsync();

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // GET: BookAuthors/AuthorDetails/5
        public async Task<IActionResult> AuthorDetails(int id)
        {
            var viewModel = new BookIndexData();

            viewModel.Author = _context.Author;

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // GET: BookAuthors/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Author, "Id", "Id");
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id");
            return View();
        }

        // POST: BookAuthors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId,AuthorId,Order")] BookAuthor bookAuthor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookAuthor);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "Id", "Id", bookAuthor.AuthorId);
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id", bookAuthor.BookId);
            return View(bookAuthor);
        }

        // GET: BookAuthors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookAuthor = await _context.BookAuthor.SingleOrDefaultAsync(m => m.BookId == id);
            if (bookAuthor == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "Id", "Id", bookAuthor.AuthorId);
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id", bookAuthor.BookId);
            return View(bookAuthor);
        }

        // POST: BookAuthors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookId,AuthorId,Order")] BookAuthor bookAuthor)
        {
            if (id != bookAuthor.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookAuthor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookAuthorExists(bookAuthor.BookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["AuthorId"] = new SelectList(_context.Author, "Id", "Id", bookAuthor.AuthorId);
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Id", bookAuthor.BookId);
            return View(bookAuthor);
        }

        // GET: BookAuthors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookAuthor = await _context.BookAuthor
                .Include(b => b.Author)
                .Include(b => b.Book)
                .SingleOrDefaultAsync(m => m.BookId == id);
            if (bookAuthor == null)
            {
                return NotFound();
            }

            return View(bookAuthor);
        }

        // POST: BookAuthors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookAuthor = await _context.BookAuthor.SingleOrDefaultAsync(m => m.BookId == id);
            _context.BookAuthor.Remove(bookAuthor);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool BookAuthorExists(int id)
        {
            return _context.BookAuthor.Any(e => e.BookId == id);
        }
    }
}
