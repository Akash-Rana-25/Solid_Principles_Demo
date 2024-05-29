using Solid_Principle_Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle_Services
{
	public interface IBookService
	{
		IEnumerable<Book> GetAllBooks();
		Book GetBookById(Guid id);
		void CreateBook(Book book);
		void UpdateBook(Book book);
		void DeleteBook(Guid id);
	}
}
