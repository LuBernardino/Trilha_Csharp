using Microsoft.AspNetCore.Mvc;
using Library.Communication.Requests;
using Library.Communication.Responses;

namespace Library.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Get([FromRoute] int id)
    {
        var response = new Book
        {
            Id = id,
            Title = "The Great Gatsby",
            Author = "F. Scott Fitzgerald",
            Genre = "Fiction",
            Price = 9.99,
            Quantity = 5
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisterBookJson
        {
            Id = 1,
            Title = request.Title,
            Author = request.Author,
            Genre = request.Genre,
            Price = request.Price,
            Quantity = request.Quantity
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<Book>()
        {
            new Book { Id = 1, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Fiction", Price = 9.99, Quantity = 15 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", Price = 12.99, Quantity = 20 },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", Genre = "Dystopian", Price = 14.99, Quantity = 25 },
            new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", Price = 8.99, Quantity = 10 },
            new Book { Id = 5, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Fiction", Price = 10.99, Quantity = 18 },
            new Book { Id = 6, Title = "Moby Dick", Author = "Herman Melville", Genre = "Adventure", Price = 11.99, Quantity = 12 },
            new Book { Id = 7, Title = "War and Peace", Author = "Leo Tolstoy", Genre = "Historical", Price = 19.99, Quantity = 8 },
            new Book { Id = 8, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", Price = 13.99, Quantity = 30 },
            new Book { Id = 9, Title = "Fahrenheit 451", Author = "Ray Bradbury", Genre = "Dystopian", Price = 9.99, Quantity = 22 },
            new Book { Id = 10, Title = "The Alchemist", Author = "Paulo Coelho", Genre = "Philosophical", Price = 10.49, Quantity = 14 }
        };

        return Ok(response);
    }
}
