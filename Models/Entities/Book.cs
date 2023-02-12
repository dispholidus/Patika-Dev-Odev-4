using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreApi.Models.Entities
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string BookTitle { get; set; } = string.Empty;
        public int GenreId { get; set; }
        public int BookPageCount { get; set; }
        public DateTime BookPublishDate { get; set; }

    }
}