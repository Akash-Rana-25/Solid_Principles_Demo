using Solid_Principle_Domain.Entity;

namespace Solid_Principle__Infrastructure.Repository
{
	public interface IBookRepository
	{
		IEnumerable<Book> GetAll();
		Book GetById(Guid id);
		void Add(Book book);
		void Update(Book book);
		void Delete(Guid id);
	}

}
