using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Art of programing"),
            new Book(2, "Refactoring"),
            new Book(3, "C programing language"),
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            books.Where(book => book.Title.Contains(titlePart))
                .ToArray();
        }
    }
     
}
