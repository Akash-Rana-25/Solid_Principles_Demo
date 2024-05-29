using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solid_Principle_Domain.Entity;
using Solid_Principle_Services;

namespace Solid_Principle__WebApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BooksController : ControllerBase
	{
		private readonly IBookService _bookService;

		public BooksController(IBookService bookService)
		{
			_bookService = bookService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Book>> Get()
		{
			var books = _bookService.GetAllBooks();
			return Ok(books);
		}

		[HttpGet("{id}")]
		public ActionResult<Book> Get(Guid id)
		{
			var book = _bookService.GetBookById(id);
			if (book == null)
			{
				return NotFound();
			}
			return Ok(book);
		}

		[HttpPost]
		public ActionResult Post([FromBody] Book book)
		{
			_bookService.CreateBook(book);
			return CreatedAtAction(nameof(Get), new { id = book.Id }, book);
		}

		[HttpPut("{id}")]
		public ActionResult Put(Guid id, [FromBody] Book book)
		{
			if (id != book.Id)
			{
				return BadRequest();
			}
			_bookService.UpdateBook(book);
			return NoContent();
		}

		[HttpDelete("{id}")]
		public ActionResult Delete(Guid id)
		{
			_bookService.DeleteBook(id);
			return NoContent();
		}
	}

}
