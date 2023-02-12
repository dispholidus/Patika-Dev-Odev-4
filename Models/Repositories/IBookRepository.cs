using AutoMapper;

namespace BookStoreApi.Models.Repositories
{
    public interface IBookRepository
    {
        public IEnumerable<BooksModel> GetBooks(IMapper mapper);
        public BookModel? GetBookById(int bookId, IMapper mapper);
        public bool DeleteBookById(int bookId);
        public bool UpdateBookById(int bookId, UpdateBookModel newBook);
        public bool AddBook(CreateBookModel newBook, IMapper mapper);
    }
}
