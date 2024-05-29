using Solid_Principle_Domain.Entity;
using Solid_Principle_Infrastructure.Context;

namespace Solid_Principle__Infrastructure.Repository
{
	public class BookRepository : IBookRepository
	{
		private readonly ApplicationDbContext _context;

		public BookRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Book> GetAll()
		{
			return _context.Books.ToList();
		}

		public Book GetById(Guid id)
		{
			return _context.Books.FirstOrDefault(b => b.Id == id);
		}

		public void Add(Book book)
		{
			_context.Books.Add(book);
		}

		public void Update(Book book)
		{
			var existingBook = GetById(book.Id);
			if (existingBook != null)
			{
				existingBook.Title = book.Title;
				existingBook.Author = book.Author;
				existingBook.ISBN = book.ISBN;
			}
		}

		public void Delete(Guid id)
		{
			var book = GetById(id);
			if (book != null)
			{
				_context.Books.Remove(book);
			}
		}
	}

}
