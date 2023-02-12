using BookStoreApi.Models.Entities;

// Generate data for test purposes.
namespace BookStoreApi.DbOperations
{
    public class DataGenerator
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            BookStoreDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookStoreDbContext>();
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        BookTitle = "Lean Startup",
                        GenreId = 1,
                        BookPageCount = 200,
                        BookPublishDate = new DateTime(2001, 06, 12)
                    },
                    new Book
                    {
                        BookTitle = "Herland",
                        GenreId = 2,
                        BookPageCount = 250,
                        BookPublishDate = new DateTime(2010, 05, 23)
                    },
                    new Book
                    {
                        BookTitle = "Dune",
                        GenreId = 2,
                        BookPageCount = 540,
                        BookPublishDate = new DateTime(2001, 12, 21)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
