using System;
using Volo.Abp.Application.Dtos;

namespace Playground.Books
{
    public class AuthorLookupDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
