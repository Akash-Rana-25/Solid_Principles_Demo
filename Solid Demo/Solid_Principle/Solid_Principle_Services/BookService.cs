using Solid_Principle__Infrastructure.Repository;
using Solid_Principle_Domain.Entity;

namespace Solid_Principle_Services
{
	public class BookService : IBookService
	{
		private readonly IBookRepository _bookRepository;

		public BookService(IBookRepository bookRepository)
		{
			_bookRepository = bookRepository;
		}

		public IEnumerable<Book> GetAllBooks()
		{
			return _bookRepository.GetAll();
		}

		public Book GetBookById(Guid id)
		{
			return _bookRepository.GetById(id);
		}

		public void CreateBook(Book book)
		{
			_bookRepository.Add(book);
		}

		public void UpdateBook(Book book)
		{
			_bookRepository.Update(book);
		}

		public void DeleteBook(Guid id)
		{
			_bookRepository.Delete(id);
		}
	}
}
