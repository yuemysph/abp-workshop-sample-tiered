using AutoMapper;
using Playground.Authors;
using Playground.Books;

namespace Playground
{
    public class PlaygroundApplicationAutoMapperProfile : Profile
    {
        public PlaygroundApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
            CreateMap<Author, AuthorDto>();
            CreateMap<Author, AuthorLookupDto>();
        }
    }
}
