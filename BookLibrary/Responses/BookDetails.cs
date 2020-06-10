using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary
{
    [Validator(typeof(BookDetailsValidator))]
    public class BookDetails
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }

    public class BookDetailsValidator : AbstractValidator<BookDetails>
    {
        public BookDetailsValidator()
        {
            RuleFor(x => x.BookId).Equal(90);
            RuleFor(x => x.Title).NotNull();
            RuleFor(x => x.Author).NotNull();
            RuleFor(x => x.Genre).NotNull();
        }
    }
}