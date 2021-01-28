using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Auditing;

namespace Playground.Books
{
    public class CreateUpdateBookDto
    {
        [DisableAuditing]
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public BookType Type { get; set; } = BookType.Undefined;

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [Required]
        public float Price { get; set; }

        public Guid AuthorId { get; set; }
    }
}
