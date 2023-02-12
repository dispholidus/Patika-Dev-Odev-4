using BookStoreApi.Models.Repositories;
using FluentValidation;

namespace BookStoreApi.Models
{
    public class BookModelValidator : AbstractValidator<BookModel>
    {
        public BookModelValidator()
        {
            RuleFor(command => command.Genre).NotEmpty();
            RuleFor(command => command.BookPageCount).GreaterThan(0);
            RuleFor(command => command.BookPublishDate).NotEmpty();
            RuleFor(command => command.BookTitle).NotEmpty().MinimumLength(4);
        }
    }
    public class CreateBookModelValidator : AbstractValidator<CreateBookModel>
    {
        public CreateBookModelValidator()
        {
            RuleFor(command => command.GenreId).GreaterThan(0);
            RuleFor(command => command.BookPageCount).GreaterThan(0);
            RuleFor(command => command.BookPublishDate.Date).NotEmpty().LessThan(DateTime.Now.Date);
            RuleFor(command => command.BookTitle).NotEmpty().MinimumLength(4);
        }
    }
    public class UpdateBookModelValidator : AbstractValidator<UpdateBookModel>
    {
        public UpdateBookModelValidator()
        {
            RuleFor(command => command.GenreId).GreaterThan(0);
            RuleFor(command => command.BookPageCount).GreaterThan(0);
            RuleFor(command => command.BookPublishDate.Date).NotEmpty().LessThan(DateTime.Now.Date);
            RuleFor(command => command.BookTitle).NotEmpty().MinimumLength(4);
        }
    }

}
